using System;
using System.Windows.Forms;

using Aerotech.A3200;
using Aerotech.A3200.Exceptions;
using Aerotech.A3200.Status;
using Aerotech.A3200.Tasks;
using Aerotech.A3200.Information;

using Logging;
using AerotechMotion;
using System.Drawing;
using UIMethods;
using System.Collections.Generic;
using System.Linq;

namespace GUI
{
	public partial class MainForm : Form
	{
		#region Fields
		static string appLoggerFileName = String.Format("Application logging {0}.txt",
				DateTime.UtcNow.ToString("yyyy-MM-dd HH-mm"));
		private Controller myController;
		private string[] axisName;
		private int axisNumber;
		private int taskIndex;
		private SysLogger sysLogger;
		private string loggerType;
		private ControllerState myControllerState;
		public bool[] axisEnabledArray;

		#endregion Fields

		#region Constructors

		public MainForm()
		{
			InitializeComponent();
		}

		private void formGUI_Load(object sender, EventArgs e)
		{
			EnableControllerBtn(false);
			EnableHome(false);
			EnableControls(false);
			loggerType = "app_logger";
			sysLogger =  new SysLogger(loggerType,appLoggerFileName);
			myControllerState = new ControllerState();
			string message = "System started";
			UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
		}

		private void formGUI_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				//Disconnect from controller
				if (myController != null)
				{
					this.myController.Commands[this.taskIndex].Axes[AxisMask.All].Motion.Disable();
					string disabled_message = "All axes disabled";
					UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", disabled_message);
				}
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
			try {
				Controller.Disconnect();
				string disconnected_message = "Controller disconnected";
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", disconnected_message);
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}

		}

		#endregion Constructors

		#region Interface
		public interface IErrorMessage
		{
			void DisplayError(string errorMessage);
		}

		#endregion

		#region Methods

		/// <summary>
		/// Enable or disable control groups
		/// </summary>
		private void EnableControllerBtn(bool enable)
		{
			btnResetController.Enabled = enable;
			btnDisconnectController.Enabled = enable;
		}
		private void EnableHome(bool enable)
		{
			groupHome.Enabled = enable;
		}
		private void EnableControls(bool enable)
		{
			
			groupAxis.Enabled = enable;
			groupTask.Enabled = enable;

		}

		/// <summary>
		/// Process task state arrived event
		/// </summary>
		private void SetTaskState(NewTaskStatesArrivedEventArgs e)
		{
			labelTaskState.Text = e.TaskStates[this.taskIndex].ToString();
		}

		/// <summary>
		/// Process DiagPacket (axis state in it) arrived event
		/// </summary>
		private void SetAxisState(NewDiagPacketArrivedEventArgs e)
		{
			
			for(int i = 0; i <= axisNumber - 1 ; i++)
			{
				AxisDiagPacket axisDiagPacket = e.Data[i];
				if (axisDiagPacket.AxisName == checkedListBoxAxis.SelectedItem.ToString())
				{
					labelAxisHomed.Text = axisDiagPacket.AxisStatus.Homed.ToString();
					labelAxisFault.Text = (!axisDiagPacket.AxisFault.None).ToString();
				}
				string Position = axisDiagPacket.PositionFeedback.ToString("f6");
				string Velocity = axisDiagPacket.VelocityFeedback.ToString();
				UIModificationStatic.SetDataListView(dataGridViewAxisDiag, axisNumber - 1-i, Position, Velocity);
				axisEnabledArray[axisNumber-1-i] = axisDiagPacket.DriveStatus.Enabled;
			}
			ledArrayAxisEnabled.SetValues(axisEnabledArray);
		}

		private void SetControllerState(ControllerEventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
		}
		#endregion Methods

		#region WindowsEvents

		private void buttonConnectController_Click(object sender, EventArgs e)
		{
			try
			{
				// Connect to A3200 controller.  
				myController = Controller.Connect();
				myControllerState.myController = myController;
				myControllerState.connected = true;
				ledConnection.Value = true;
				EnableControllerBtn(true);
				EnableHome(true);
				string message = "Controller connected";
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
				// populate axis names
				
				foreach (MotionDriveInformation motionDriveInformation in myController.Information.MotionDrives)
				{
					foreach (AxisInfo axisInfo in motionDriveInformation.Axes)
					{
						checkedListBoxAxis.Items.Add(axisInfo.Name);
					}
					axisNumber += 1;	
				}
				
				checkedListBoxAxis.SelectedIndex = 0;
				checkedListBoxAxis.SetItemChecked(0, true);
				UIModificationStatic.InitializeDataListView(dataGridViewAxisDiag, axisNumber);
				UIModificationStatic.SetLEDArray(ledArrayAxisEnabled, axisNumber);
				UIModificationStatic.SetSwitchArray(switchArrayAxisEnable, axisNumber);
				axisEnabledArray = new bool[axisNumber];
				// populate task names
				foreach (Task task in this.myController.Tasks)
				{
					if (task.State != TaskState.Inactive)
					{
						comboTask.Items.Add(task.Name.ToString());
					}
				}
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
		}

		private void buttonEnableAxis_Click(object sender, EventArgs e)
		{
			try
			{
				string axisNameCollection = UIMethods.UIModificationStatic.AxisCollectionLog(axisName);
				if (axisName.Length >0)
					this.myController.Commands[this.taskIndex].Axes[this.axisName].Motion.Enable();
				string message = axisNameCollection+ " axis enabled";
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
		}

		private void buttonDisableAxis_Click(object sender, EventArgs e)
		{
			try
			{
				string axisNameCollection = UIMethods.UIModificationStatic.AxisCollectionLog(axisName);
				if (axisName.Length >0)
					this.myController.Commands[this.taskIndex].Axes[this.axisName].Motion.Disable();
				string message = axisNameCollection + " axis disabled";
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
		}

		private void comboTask_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Task 0 is reserved
			this.taskIndex = comboTask.SelectedIndex + 1;
		}

		private void buttonRunProgram_Click(object sender, EventArgs e)
		{
			try
			{
				   this.myController.Tasks[this.taskIndex].Program.Run(textProgram.Text);
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
		}

		private void buttonStopProgram_Click(object sender, EventArgs e)
		{

			try
			{
				this.myController.Tasks[this.taskIndex].Program.Stop();
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
		}

		/// <summary>
		/// Hold down Freerun button, the axis will move
		/// </summary>
		private void buttonFreerunCW_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				this.myController.Commands[this.taskIndex].Motion.FreeRun(checkedListBoxAxis.SelectedItem.ToString(), double.Parse(textFreerunSpeed.Text));
				string message = checkedListBoxAxis.SelectedItem.ToString() + " axis starts CW free running with a speed of "+ textFreerunSpeed.Text;
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
				
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
		}

		/// <summary>
		/// Release Freerun button, the axis will stop
		/// </summary>
		private void buttonFreerunCW_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				this.myController.Commands[this.taskIndex].Motion.FreeRun(checkedListBoxAxis.SelectedItem.ToString(), 0);
				
				string message = checkedListBoxAxis.SelectedItem.ToString() + " axis ends CW free running at "+dataGridViewAxisDiag.Rows[checkedListBoxAxis.SelectedIndex].Cells[0].Value ;
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
		}

		/// <summary>
		/// Hold down Freerun button, the axis will move
		/// </summary>
		private void buttonFreerunCCW_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				this.myController.Commands[this.taskIndex].Motion.FreeRun(checkedListBoxAxis.SelectedItem.ToString(), -double.Parse(textFreerunSpeed.Text));
				string message = checkedListBoxAxis.SelectedItem.ToString() + " axis starts CCW free running with a speed of " + textFreerunSpeed.Text;
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
		}

		/// <summary>
		/// Release Freerun button, the axis will stop
		/// </summary>
		private void buttonFreerunCCW_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				this.myController.Commands[this.taskIndex].Motion.FreeRun(checkedListBoxAxis.SelectedItem.ToString(), 0);

				string message = checkedListBoxAxis.SelectedItem.ToString() + " axis ends CCW free running at " + dataGridViewAxisDiag.Rows[checkedListBoxAxis.SelectedIndex].Cells[0].Value;
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
		}

		#endregion WindowsEvents

		#region ControllerEvents

		/// <summary>
		/// Handle task state arrived event. Invoke SetTaskState to process data
		/// </summary>
		private void TaskStates_NewTaskStatesArrived(object sender, NewTaskStatesArrivedEventArgs e)
		{
			try
			{
				//URL: http://msdn.microsoft.com/en-us/library/ms171728.aspx
				//How to: Make Thread-Safe Calls to Windows Forms Controls
				this.Invoke(new Action<NewTaskStatesArrivedEventArgs>(SetTaskState), e);
			}
			catch
			{
			}
		}

		/// <summary>
		/// Handle DiagPacket (axis state in it) arrived event. Invoke SetAxisState to process data
		/// </summary>
		private void Diagnostics_NewDiagPacketArrived(object sender, NewDiagPacketArrivedEventArgs e)
		{
			try
			{
				//URL: http://msdn.microsoft.com/en-us/library/ms171728.aspx
				//How to: Make Thread-Safe Calls to Windows Forms Controls
				this.Invoke(new Action<NewDiagPacketArrivedEventArgs>(SetAxisState), e);
			}
			catch
			{
			}
		}
		/// <summary>
		/// Handle Controller resetting event. Invoke SetAxisState to process data
		/// </summary>
		private void ControllerState_ControllerResetting(object sender, Aerotech.A3200.Status.ControllerEventArgs e)
		{
			try
			{
				this.Invoke(new Action<ControllerEventArgs>(SetControllerState), e);
			}
			catch { }
		}

		#endregion ControllerEvents

		private void Scope_Click(object sender, EventArgs e)
        {
			var monitorForm = Application.OpenForms["MonitorForm"];
			if (monitorForm == null)
			{
				monitorForm = new MonitorForm();
				monitorForm.Show();
			}
			else
			{
				monitorForm.Focus();
			}
			
		}

        private void HomeBtn_Click(object sender, EventArgs e)
        {
			try
			{
				this.myController.Commands.Axes["X", "Y", "THETA"].Motion.Enable();
				this.myController.Commands.Axes["X", "Y", "THETA"].Motion.Home();
				 
				EnableControls(true);
				string message = "All axes homed";
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
				// Task 0 is reserved
				this.taskIndex = 1;
				comboTask.SelectedIndex = this.taskIndex - 1;

				// register task state and diagPackect arrived events
				this.myController.ControlCenter.TaskStates.NewTaskStatesArrived += new EventHandler<NewTaskStatesArrivedEventArgs>(TaskStates_NewTaskStatesArrived);
				this.myController.ControlCenter.Diagnostics.NewDiagPacketArrived += new EventHandler<NewDiagPacketArrivedEventArgs>(Diagnostics_NewDiagPacketArrived);
				
				// axis mask
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage,sysLogger, exception.Criticality.ToString(), exception.Message);
			}
			
		}

        private void labelMessage_Click(object sender, EventArgs e)
        {
			UIModificationStatic.ShowLoggerForm(this,sysLogger);
		}

        private void laebelMessage_Click(object sender, EventArgs e)
        {
			UIModificationStatic.ShowLoggerForm(this, sysLogger);
		}

        private void StopBtn_Click(object sender, EventArgs e)
        {
			try
			{
				this.myController.Commands[this.taskIndex].Axes[AxisMask.All].Motion.Disable();
				string message = "All axes disabled";
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
		}

        private void btnResetController_Click(object sender, EventArgs e)
        {
			try
			{
				myControllerState.ControllerResetting += new EventHandler<ControllerEventArgs>(ControllerState_ControllerResetting);
				this.Cursor = Cursors.WaitCursor;

				myControllerState.Reset();

				this.Cursor = Cursors.Default;
				string message = "Controller reset";
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
        }

        private void btnDisconnectController_Click(object sender, EventArgs e)
        {
			try
			{
				myControllerState.Disconnect();
				ledConnection.Value = false;
				EnableControls(false);
				string message = "Controller disconnected";
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
			}
			catch (A3200Exception exception)
			{
				UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, exception.Criticality.ToString(), exception.Message);
			}
		}

        private void btnGenerator_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFreerunCW_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFreerunCCW_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBoxAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
			string message = checkedListBoxAxis.SelectedItem.ToString()+" axis selected";
			UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
		}
		private void checkedListBoxAxis_ItemChecked(object sender, ItemCheckEventArgs e)
		{
			List<string> checkedItems = new List<string>();
			foreach (var item in checkedListBoxAxis.CheckedItems)
				checkedItems.Add(item.ToString());
			if (e.NewValue == CheckState.Checked)
				checkedItems.Add(checkedListBoxAxis.Items[e.Index].ToString());
			else
				checkedItems.Remove(checkedListBoxAxis.Items[e.Index].ToString());

			axisName = checkedItems.OfType<string>().ToArray();
		}

	}
}
