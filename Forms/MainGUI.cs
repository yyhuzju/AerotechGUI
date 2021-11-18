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

namespace GUI
{
	public partial class MainForm : Form
	{
		#region Fields

		private Controller myController;
		private int axisIndex;
		private string axisName;
		private int taskIndex;
		private SysLogger sysLogger;
		private ControllerState myControllerState;

		#endregion Fields

		#region Constructors

		public MainForm()
		{
			InitializeComponent();
		}

		private void formGUI_Load(object sender, EventArgs e)
		{
			EnableHome(false);
			EnableControls(false);
			sysLogger =  new SysLogger("app_logger");
			myControllerState = new ControllerState();
		}

		private void formGUI_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Disconnect from controller
			Controller.Disconnect();
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

		private void EnableHome(bool enable)
		{
			groupHome.Enabled = enable;
		}
		private void EnableControls(bool enable)
		{
			
			groupAxis.Enabled = enable;
			groupTask.Enabled = enable;

		}

		private void DisplayStatus(string eS)
		{
			labelStatus.Text = eS;
		}
		private void DisplayMessage(string eM)
		{
			labelMessage.Text = eM;
		}
		public void Logging(string eS, string eM)
		{

			switch(eS)
			{
				case "Error":
					sysLogger.Error(eM);
					this.labelStatus.BackColor = Color.Red;
					break;
				case "FatalError":
					sysLogger.Fatal(eM);
					this.labelStatus.BackColor = Color.DarkRed;
					break;
				case "Warning":
					sysLogger.Warn(eM);
					this.labelStatus.BackColor = Color.Yellow;
					break;
				default:
					sysLogger.Info(eM);
					this.labelStatus.BackColor = Color.Green;
					break;
			}
			DisplayStatus(eS);
			DisplayMessage(eM);
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
			labelAxisState.Text = e.Data[this.axisIndex].DriveStatus.Enabled.ToString();
			labelAxisHomed.Text = e.Data[this.axisIndex].AxisStatus.Homed.ToString();
			labelAxisFault.Text = (!e.Data[this.axisIndex].AxisFault.None).ToString();
			labelAxisPosition.Text = e.Data[this.axisIndex].PositionFeedback.ToString("f6");
			labelAxisSpeed.Text = e.Data[this.axisIndex].VelocityFeedback.ToString();
		}

		private void SetControllerState(ControllerEventArgs e)
		{
			
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
				EnableHome(true);
				Logging("Info", "Controller connected");
				// populate axis names
				foreach (AxisInfo axis in myController.Information.Axes)
				{
					comboAxis.Items.Add(axis.Name);
				}
				this.axisIndex = 0;
				comboAxis.SelectedIndex = this.axisIndex;
				this.axisName = comboAxis.Text;

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
				Logging(exception.Criticality.ToString(), exception.Message);
			}
		}

		private void buttonEnableAxis_Click(object sender, EventArgs e)
		{
			try
			{
				this.myController.Commands[this.taskIndex].Axes[this.axisIndex].Motion.Enable();
				string message = "Axis " + this.axisName + " enabled";
				Logging("Info", message);
			}
			catch (A3200Exception exception)
			{
				Logging(exception.Criticality.ToString(), exception.Message);
			}
		}

		private void buttonDisableAxis_Click(object sender, EventArgs e)
		{
			try
			{
				this.myController.Commands[this.taskIndex].Axes[this.axisIndex].Motion.Disable();
				string message = "Axis " + this.axisName + " disabled";
				Logging("Info", message);
			}
			catch (A3200Exception exception)
			{
				Logging(exception.Criticality.ToString(), exception.Message);
			}
		}

		private void comboAxis_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.axisIndex = comboAxis.SelectedIndex;
			this.axisName = comboAxis.Text;
		}

		private void comboTask_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Task 0 is reserved
			this.taskIndex = comboTask.SelectedIndex + 1;
		}

		private void buttonExecuteGenericString_Click(object sender, EventArgs e)
		{
			try
			{
				this.myController.Commands[this.taskIndex].Execute(textGenericString.Text);
			}
			catch (A3200Exception exception)
			{
				Logging(exception.Criticality.ToString(), exception.Message);
			}
		}

		private void buttonRunProgram_Click(object sender, EventArgs e)
		{
			try
			{
				this.myController.Tasks[this.taskIndex].Program.Run(textProgram.Text);
			}
			catch (A3200Exception exception)
			{
				Logging(exception.Criticality.ToString(), exception.Message);
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
				Logging(exception.Criticality.ToString(), exception.Message);
			}
		}

		/// <summary>
		/// Hold down Freerun button, the axis will move
		/// </summary>
		private void buttonFreerunCW_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, double.Parse(textFreerunSpeed.Text));
			}
			catch (A3200Exception exception)
			{
				Logging(exception.Criticality.ToString(), exception.Message);
			}
		}

		/// <summary>
		/// Release Freerun button, the axis will stop
		/// </summary>
		private void buttonFreerunCW_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, 0);
			}
			catch (A3200Exception exception)
			{
				Logging(exception.Criticality.ToString(), exception.Message);
			}
		}

		/// <summary>
		/// Hold down Freerun button, the axis will move
		/// </summary>
		private void buttonFreerunCCW_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, -double.Parse(textFreerunSpeed.Text));
			}
			catch (A3200Exception exception)
			{
				Logging(exception.Criticality.ToString(), exception.Message);
			}
		}

		/// <summary>
		/// Release Freerun button, the axis will stop
		/// </summary>
		private void buttonFreerunCCW_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, 0);
			}
			catch (A3200Exception exception)
			{
				Logging(exception.Criticality.ToString(), exception.Message);
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
				Logging("Info", message);
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
				Logging(exception.Criticality.ToString(), exception.Message);
			}
			
		}

        private void labelMessage_Click(object sender, EventArgs e)
        {
			var loggerForm = Application.OpenForms["LoggerForm"];
			if (loggerForm == null)
			{
				loggerForm = new LoggerForm(sysLogger.logger,sysLogger.logFilePath);
				loggerForm.Show();
			}
			else
			{
				loggerForm.Focus();
			}

		}

        private void laebelMessage_Click(object sender, EventArgs e)
        {
			var loggerForm = Application.OpenForms["LoggerForm"];
			if (loggerForm == null)
			{
				loggerForm = new LoggerForm(sysLogger.logger, sysLogger.logFilePath);
				loggerForm.Show();
			}
			else
			{
				loggerForm.Focus();
			}

		}

        private void StopBtn_Click(object sender, EventArgs e)
        {
			try
			{
				this.myController.Commands[this.taskIndex].Axes[AxisMask.All].Motion.Disable();
				string message = "All axes disabled";
				Logging("Info", message);
			}
			catch (A3200Exception exception)
			{
				Logging(exception.Criticality.ToString(), exception.Message);
			}
		}

        private void btnResetController_Click(object sender, EventArgs e)
        {
			try
			{
				myControllerState.ControllerResetting += new EventHandler<ControllerEventArgs>(ControllerState_ControllerResetting);
				myControllerState.Reset();
				string message = "Controller reset";
				Logging("Info", message);
			}
			catch (A3200Exception exception)
			{
				Logging(exception.Criticality.ToString(), exception.Message);
			}
        }

        private void btnDisconnectController_Click(object sender, EventArgs e)
        {
			try
			{
				myControllerState.Disconnect();
				EnableControls(false);
				string message = "Controller disconnected";
				Logging("Info", message);
			}
			catch (A3200Exception exception)
			{
				Logging(exception.Criticality.ToString(), exception.Message);
			}
		}
    }
}
