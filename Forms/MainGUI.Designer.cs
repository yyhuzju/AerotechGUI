namespace GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.buttonConnectController = new System.Windows.Forms.Button();
            this.groupController = new System.Windows.Forms.GroupBox();
            this.ledConnection = new NationalInstruments.UI.WindowsForms.Led();
            this.btnResetController = new System.Windows.Forms.Button();
            this.btnDisconnectController = new System.Windows.Forms.Button();
            this.groupAxis = new System.Windows.Forms.GroupBox();
            this.tabControlAxisMotion = new System.Windows.Forms.TabControl();
            this.QuickRunTab = new System.Windows.Forms.TabPage();
            this.groupFreerun = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonDisableAxis = new System.Windows.Forms.Button();
            this.ButtonEnableAxis = new System.Windows.Forms.Button();
            this.labelAxisFault = new System.Windows.Forms.Label();
            this.textFreerunSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonFreerunCCW = new System.Windows.Forms.Button();
            this.labelAxisHomed = new System.Windows.Forms.Label();
            this.ButtonFreerunCW = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FreeRunTab = new System.Windows.Forms.TabPage();
            this.velocityEditArray = new NationalInstruments.UI.WindowsForms.NumericEditArray();
            this.LinearMotionTab = new System.Windows.Forms.TabPage();
            this.groupAxisSelection = new System.Windows.Forms.GroupBox();
            this.checkedListBoxAxis = new System.Windows.Forms.CheckedListBox();
            this.switchArrayAxisEnable = new NationalInstruments.UI.WindowsForms.SwitchArray();
            this.ledArrayAxisEnabled = new NationalInstruments.UI.WindowsForms.LedArray();
            this.axisLabel = new System.Windows.Forms.Label();
            this.groupAxisState = new System.Windows.Forms.GroupBox();
            this.velLabel = new System.Windows.Forms.Label();
            this.posLabel = new System.Windows.Forms.Label();
            this.dataGridViewAxisDiag = new System.Windows.Forms.DataGridView();
            this.groupTask = new System.Windows.Forms.GroupBox();
            this.groupProgram = new System.Windows.Forms.GroupBox();
            this.textProgram = new System.Windows.Forms.TextBox();
            this.buttonStopProgram = new System.Windows.Forms.Button();
            this.buttonRunProgram = new System.Windows.Forms.Button();
            this.labelTaskState = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboTask = new System.Windows.Forms.ComboBox();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.groupHome = new System.Windows.Forms.GroupBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.groupController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledConnection)).BeginInit();
            this.groupAxis.SuspendLayout();
            this.tabControlAxisMotion.SuspendLayout();
            this.QuickRunTab.SuspendLayout();
            this.groupFreerun.SuspendLayout();
            this.FreeRunTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.velocityEditArray.ItemTemplate)).BeginInit();
            this.groupAxisSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchArrayAxisEnable.ItemTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledArrayAxisEnabled.ItemTemplate)).BeginInit();
            this.groupAxisState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAxisDiag)).BeginInit();
            this.groupTask.SuspendLayout();
            this.groupProgram.SuspendLayout();
            this.groupHome.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnectController
            // 
            this.buttonConnectController.Location = new System.Drawing.Point(27, 26);
            this.buttonConnectController.Name = "buttonConnectController";
            this.buttonConnectController.Size = new System.Drawing.Size(58, 25);
            this.buttonConnectController.TabIndex = 0;
            this.buttonConnectController.Text = "Connect";
            this.buttonConnectController.UseVisualStyleBackColor = true;
            this.buttonConnectController.Click += new System.EventHandler(this.buttonConnectController_Click);
            // 
            // groupController
            // 
            this.groupController.Controls.Add(this.ledConnection);
            this.groupController.Controls.Add(this.btnResetController);
            this.groupController.Controls.Add(this.btnDisconnectController);
            this.groupController.Controls.Add(this.buttonConnectController);
            this.groupController.Location = new System.Drawing.Point(12, 11);
            this.groupController.Name = "groupController";
            this.groupController.Size = new System.Drawing.Size(226, 66);
            this.groupController.TabIndex = 3;
            this.groupController.TabStop = false;
            this.groupController.Text = "Controller";
            // 
            // ledConnection
            // 
            this.ledConnection.LedStyle = NationalInstruments.UI.LedStyle.Square;
            this.ledConnection.Location = new System.Drawing.Point(0, 26);
            this.ledConnection.Name = "ledConnection";
            this.ledConnection.Size = new System.Drawing.Size(27, 25);
            this.ledConnection.TabIndex = 3;
            // 
            // btnResetController
            // 
            this.btnResetController.Location = new System.Drawing.Point(90, 26);
            this.btnResetController.Name = "btnResetController";
            this.btnResetController.Size = new System.Drawing.Size(58, 25);
            this.btnResetController.TabIndex = 2;
            this.btnResetController.Text = "Reset";
            this.btnResetController.UseVisualStyleBackColor = true;
            this.btnResetController.Click += new System.EventHandler(this.btnResetController_Click);
            // 
            // btnDisconnectController
            // 
            this.btnDisconnectController.Location = new System.Drawing.Point(153, 26);
            this.btnDisconnectController.Name = "btnDisconnectController";
            this.btnDisconnectController.Size = new System.Drawing.Size(67, 25);
            this.btnDisconnectController.TabIndex = 1;
            this.btnDisconnectController.Text = "Disonnect";
            this.btnDisconnectController.UseVisualStyleBackColor = true;
            this.btnDisconnectController.Click += new System.EventHandler(this.btnDisconnectController_Click);
            // 
            // groupAxis
            // 
            this.groupAxis.Controls.Add(this.tabControlAxisMotion);
            this.groupAxis.Controls.Add(this.groupAxisSelection);
            this.groupAxis.Controls.Add(this.groupAxisState);
            this.groupAxis.Location = new System.Drawing.Point(12, 207);
            this.groupAxis.Name = "groupAxis";
            this.groupAxis.Size = new System.Drawing.Size(660, 164);
            this.groupAxis.TabIndex = 4;
            this.groupAxis.TabStop = false;
            this.groupAxis.Text = "Axis";
            // 
            // tabControlAxisMotion
            // 
            this.tabControlAxisMotion.Controls.Add(this.QuickRunTab);
            this.tabControlAxisMotion.Controls.Add(this.FreeRunTab);
            this.tabControlAxisMotion.Controls.Add(this.LinearMotionTab);
            this.tabControlAxisMotion.Location = new System.Drawing.Point(405, 12);
            this.tabControlAxisMotion.Name = "tabControlAxisMotion";
            this.tabControlAxisMotion.SelectedIndex = 0;
            this.tabControlAxisMotion.Size = new System.Drawing.Size(255, 142);
            this.tabControlAxisMotion.TabIndex = 25;
            // 
            // QuickRunTab
            // 
            this.QuickRunTab.Controls.Add(this.groupFreerun);
            this.QuickRunTab.Location = new System.Drawing.Point(4, 22);
            this.QuickRunTab.Name = "QuickRunTab";
            this.QuickRunTab.Padding = new System.Windows.Forms.Padding(3);
            this.QuickRunTab.Size = new System.Drawing.Size(227, 116);
            this.QuickRunTab.TabIndex = 0;
            this.QuickRunTab.Text = "Quick Start";
            this.QuickRunTab.UseVisualStyleBackColor = true;
            // 
            // groupFreerun
            // 
            this.groupFreerun.Controls.Add(this.label1);
            this.groupFreerun.Controls.Add(this.ButtonDisableAxis);
            this.groupFreerun.Controls.Add(this.ButtonEnableAxis);
            this.groupFreerun.Controls.Add(this.labelAxisFault);
            this.groupFreerun.Controls.Add(this.textFreerunSpeed);
            this.groupFreerun.Controls.Add(this.label2);
            this.groupFreerun.Controls.Add(this.ButtonFreerunCCW);
            this.groupFreerun.Controls.Add(this.labelAxisHomed);
            this.groupFreerun.Controls.Add(this.ButtonFreerunCW);
            this.groupFreerun.Controls.Add(this.label3);
            this.groupFreerun.Location = new System.Drawing.Point(6, 3);
            this.groupFreerun.Name = "groupFreerun";
            this.groupFreerun.Size = new System.Drawing.Size(333, 110);
            this.groupFreerun.TabIndex = 17;
            this.groupFreerun.TabStop = false;
            this.groupFreerun.Text = "Freerun";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Speed";
            // 
            // ButtonDisableAxis
            // 
            this.ButtonDisableAxis.Location = new System.Drawing.Point(65, 84);
            this.ButtonDisableAxis.Name = "ButtonDisableAxis";
            this.ButtonDisableAxis.Size = new System.Drawing.Size(56, 23);
            this.ButtonDisableAxis.TabIndex = 5;
            this.ButtonDisableAxis.Text = "Disable";
            this.ButtonDisableAxis.UseVisualStyleBackColor = true;
            this.ButtonDisableAxis.Click += new System.EventHandler(this.buttonDisableAxis_Click);
            // 
            // ButtonEnableAxis
            // 
            this.ButtonEnableAxis.Location = new System.Drawing.Point(3, 85);
            this.ButtonEnableAxis.Name = "ButtonEnableAxis";
            this.ButtonEnableAxis.Size = new System.Drawing.Size(56, 22);
            this.ButtonEnableAxis.TabIndex = 4;
            this.ButtonEnableAxis.Text = "Enable";
            this.ButtonEnableAxis.UseVisualStyleBackColor = true;
            this.ButtonEnableAxis.Click += new System.EventHandler(this.buttonEnableAxis_Click);
            // 
            // labelAxisFault
            // 
            this.labelAxisFault.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAxisFault.Location = new System.Drawing.Point(148, 51);
            this.labelAxisFault.Name = "labelAxisFault";
            this.labelAxisFault.Size = new System.Drawing.Size(39, 16);
            this.labelAxisFault.TabIndex = 19;
            // 
            // textFreerunSpeed
            // 
            this.textFreerunSpeed.Location = new System.Drawing.Point(52, 18);
            this.textFreerunSpeed.Name = "textFreerunSpeed";
            this.textFreerunSpeed.Size = new System.Drawing.Size(40, 21);
            this.textFreerunSpeed.TabIndex = 9;
            this.textFreerunSpeed.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fault";
            // 
            // ButtonFreerunCCW
            // 
            this.ButtonFreerunCCW.Location = new System.Drawing.Point(52, 47);
            this.ButtonFreerunCCW.Name = "ButtonFreerunCCW";
            this.ButtonFreerunCCW.Size = new System.Drawing.Size(40, 22);
            this.ButtonFreerunCCW.TabIndex = 8;
            this.ButtonFreerunCCW.Text = "CCW";
            this.ButtonFreerunCCW.UseVisualStyleBackColor = true;
            this.ButtonFreerunCCW.Click += new System.EventHandler(this.ButtonFreerunCCW_Click);
            this.ButtonFreerunCCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFreerunCCW_MouseDown);
            this.ButtonFreerunCCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonFreerunCCW_MouseUp);
            // 
            // labelAxisHomed
            // 
            this.labelAxisHomed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAxisHomed.Location = new System.Drawing.Point(148, 20);
            this.labelAxisHomed.Name = "labelAxisHomed";
            this.labelAxisHomed.Size = new System.Drawing.Size(39, 16);
            this.labelAxisHomed.TabIndex = 17;
            // 
            // ButtonFreerunCW
            // 
            this.ButtonFreerunCW.Location = new System.Drawing.Point(3, 47);
            this.ButtonFreerunCW.Name = "ButtonFreerunCW";
            this.ButtonFreerunCW.Size = new System.Drawing.Size(40, 22);
            this.ButtonFreerunCW.TabIndex = 7;
            this.ButtonFreerunCW.Text = "CW";
            this.ButtonFreerunCW.UseVisualStyleBackColor = true;
            this.ButtonFreerunCW.Click += new System.EventHandler(this.ButtonFreerunCW_Click);
            this.ButtonFreerunCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFreerunCW_MouseDown);
            this.ButtonFreerunCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonFreerunCW_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Homed";
            // 
            // FreeRunTab
            // 
            this.FreeRunTab.Controls.Add(this.elementHost1);
            this.FreeRunTab.Controls.Add(this.velocityEditArray);
            this.FreeRunTab.Location = new System.Drawing.Point(4, 22);
            this.FreeRunTab.Name = "FreeRunTab";
            this.FreeRunTab.Padding = new System.Windows.Forms.Padding(3);
            this.FreeRunTab.Size = new System.Drawing.Size(247, 116);
            this.FreeRunTab.TabIndex = 1;
            this.FreeRunTab.Text = "Free Run";
            this.FreeRunTab.UseVisualStyleBackColor = true;
            // 
            // velocityEditArray
            // 
            // 
            // 
            // 
            this.velocityEditArray.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.velocityEditArray.ItemTemplate.Name = "";
            this.velocityEditArray.ItemTemplate.Range = new NationalInstruments.UI.Range(0D, 100D);
            this.velocityEditArray.ItemTemplate.TabIndex = 0;
            this.velocityEditArray.ItemTemplate.TabStop = false;
            this.velocityEditArray.Location = new System.Drawing.Point(7, 30);
            this.velocityEditArray.Name = "velocityEditArray";
            this.velocityEditArray.Size = new System.Drawing.Size(135, 76);
            this.velocityEditArray.TabIndex = 0;
            // 
            // LinearMotionTab
            // 
            this.LinearMotionTab.Location = new System.Drawing.Point(4, 22);
            this.LinearMotionTab.Name = "LinearMotionTab";
            this.LinearMotionTab.Padding = new System.Windows.Forms.Padding(3);
            this.LinearMotionTab.Size = new System.Drawing.Size(227, 116);
            this.LinearMotionTab.TabIndex = 2;
            this.LinearMotionTab.Text = "Linear Motion";
            this.LinearMotionTab.UseVisualStyleBackColor = true;
            // 
            // groupAxisSelection
            // 
            this.groupAxisSelection.AutoSize = true;
            this.groupAxisSelection.Controls.Add(this.checkedListBoxAxis);
            this.groupAxisSelection.Controls.Add(this.switchArrayAxisEnable);
            this.groupAxisSelection.Controls.Add(this.ledArrayAxisEnabled);
            this.groupAxisSelection.Controls.Add(this.axisLabel);
            this.groupAxisSelection.Location = new System.Drawing.Point(5, 17);
            this.groupAxisSelection.Name = "groupAxisSelection";
            this.groupAxisSelection.Size = new System.Drawing.Size(182, 143);
            this.groupAxisSelection.TabIndex = 24;
            this.groupAxisSelection.TabStop = false;
            this.groupAxisSelection.Text = "Axis Selection";
            // 
            // checkedListBoxAxis
            // 
            this.checkedListBoxAxis.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxAxis.FormattingEnabled = true;
            this.checkedListBoxAxis.Location = new System.Drawing.Point(37, 47);
            this.checkedListBoxAxis.Name = "checkedListBoxAxis";
            this.checkedListBoxAxis.Size = new System.Drawing.Size(106, 76);
            this.checkedListBoxAxis.TabIndex = 22;
            this.checkedListBoxAxis.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxAxis_ItemChecked);
            this.checkedListBoxAxis.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAxis_SelectedIndexChanged);
            // 
            // switchArrayAxisEnable
            // 
            // 
            // 
            // 
            this.switchArrayAxisEnable.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.switchArrayAxisEnable.ItemTemplate.Name = "";
            this.switchArrayAxisEnable.ItemTemplate.Size = new System.Drawing.Size(24, 24);
            this.switchArrayAxisEnable.ItemTemplate.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switchArrayAxisEnable.ItemTemplate.TabIndex = 0;
            this.switchArrayAxisEnable.ItemTemplate.TabStop = false;
            this.switchArrayAxisEnable.Location = new System.Drawing.Point(1, 47);
            this.switchArrayAxisEnable.Name = "switchArrayAxisEnable";
            this.switchArrayAxisEnable.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(1);
            this.switchArrayAxisEnable.Size = new System.Drawing.Size(34, 76);
            this.switchArrayAxisEnable.TabIndex = 27;
            // 
            // ledArrayAxisEnabled
            // 
            // 
            // 
            // 
            this.ledArrayAxisEnabled.ItemTemplate.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.ledArrayAxisEnabled.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.ledArrayAxisEnabled.ItemTemplate.Name = "";
            this.ledArrayAxisEnabled.ItemTemplate.OffColor = System.Drawing.Color.DarkRed;
            this.ledArrayAxisEnabled.ItemTemplate.Size = new System.Drawing.Size(24, 24);
            this.ledArrayAxisEnabled.ItemTemplate.TabIndex = 0;
            this.ledArrayAxisEnabled.ItemTemplate.TabStop = false;
            this.ledArrayAxisEnabled.Location = new System.Drawing.Point(145, 47);
            this.ledArrayAxisEnabled.Name = "ledArrayAxisEnabled";
            this.ledArrayAxisEnabled.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(1);
            this.ledArrayAxisEnabled.Size = new System.Drawing.Size(31, 76);
            this.ledArrayAxisEnabled.TabIndex = 26;
            // 
            // axisLabel
            // 
            this.axisLabel.AutoSize = true;
            this.axisLabel.Location = new System.Drawing.Point(45, 32);
            this.axisLabel.Name = "axisLabel";
            this.axisLabel.Size = new System.Drawing.Size(89, 12);
            this.axisLabel.TabIndex = 25;
            this.axisLabel.Text = "Available Axes";
            // 
            // groupAxisState
            // 
            this.groupAxisState.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupAxisState.Controls.Add(this.velLabel);
            this.groupAxisState.Controls.Add(this.posLabel);
            this.groupAxisState.Controls.Add(this.dataGridViewAxisDiag);
            this.groupAxisState.Location = new System.Drawing.Point(187, 17);
            this.groupAxisState.Name = "groupAxisState";
            this.groupAxisState.Size = new System.Drawing.Size(212, 141);
            this.groupAxisState.TabIndex = 16;
            this.groupAxisState.TabStop = false;
            this.groupAxisState.Text = "Axis State";
            // 
            // velLabel
            // 
            this.velLabel.AutoSize = true;
            this.velLabel.Location = new System.Drawing.Point(127, 24);
            this.velLabel.Name = "velLabel";
            this.velLabel.Size = new System.Drawing.Size(53, 12);
            this.velLabel.TabIndex = 25;
            this.velLabel.Text = "Velocity";
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Location = new System.Drawing.Point(32, 24);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(53, 12);
            this.posLabel.TabIndex = 24;
            this.posLabel.Text = "Position";
            // 
            // dataGridViewAxisDiag
            // 
            this.dataGridViewAxisDiag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAxisDiag.ColumnHeadersVisible = false;
            this.dataGridViewAxisDiag.Location = new System.Drawing.Point(6, 47);
            this.dataGridViewAxisDiag.Name = "dataGridViewAxisDiag";
            this.dataGridViewAxisDiag.RowHeadersVisible = false;
            this.dataGridViewAxisDiag.RowTemplate.Height = 23;
            this.dataGridViewAxisDiag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewAxisDiag.Size = new System.Drawing.Size(200, 76);
            this.dataGridViewAxisDiag.TabIndex = 23;
            // 
            // groupTask
            // 
            this.groupTask.Controls.Add(this.groupProgram);
            this.groupTask.Controls.Add(this.labelTaskState);
            this.groupTask.Controls.Add(this.label9);
            this.groupTask.Controls.Add(this.comboTask);
            this.groupTask.Location = new System.Drawing.Point(12, 82);
            this.groupTask.Name = "groupTask";
            this.groupTask.Size = new System.Drawing.Size(644, 119);
            this.groupTask.TabIndex = 5;
            this.groupTask.TabStop = false;
            this.groupTask.Text = "Task";
            // 
            // groupProgram
            // 
            this.groupProgram.Controls.Add(this.textProgram);
            this.groupProgram.Controls.Add(this.buttonStopProgram);
            this.groupProgram.Controls.Add(this.buttonRunProgram);
            this.groupProgram.Location = new System.Drawing.Point(6, 44);
            this.groupProgram.Name = "groupProgram";
            this.groupProgram.Size = new System.Drawing.Size(634, 67);
            this.groupProgram.TabIndex = 16;
            this.groupProgram.TabStop = false;
            this.groupProgram.Text = "Program";
            // 
            // textProgram
            // 
            this.textProgram.Location = new System.Drawing.Point(69, 15);
            this.textProgram.Name = "textProgram";
            this.textProgram.Size = new System.Drawing.Size(561, 21);
            this.textProgram.TabIndex = 15;
            // 
            // buttonStopProgram
            // 
            this.buttonStopProgram.Location = new System.Drawing.Point(6, 42);
            this.buttonStopProgram.Name = "buttonStopProgram";
            this.buttonStopProgram.Size = new System.Drawing.Size(56, 20);
            this.buttonStopProgram.TabIndex = 14;
            this.buttonStopProgram.Text = "Stop";
            this.buttonStopProgram.UseVisualStyleBackColor = true;
            this.buttonStopProgram.Click += new System.EventHandler(this.buttonStopProgram_Click);
            // 
            // buttonRunProgram
            // 
            this.buttonRunProgram.Location = new System.Drawing.Point(6, 17);
            this.buttonRunProgram.Name = "buttonRunProgram";
            this.buttonRunProgram.Size = new System.Drawing.Size(57, 19);
            this.buttonRunProgram.TabIndex = 6;
            this.buttonRunProgram.Text = "Run";
            this.buttonRunProgram.UseVisualStyleBackColor = true;
            this.buttonRunProgram.Click += new System.EventHandler(this.buttonRunProgram_Click);
            // 
            // labelTaskState
            // 
            this.labelTaskState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTaskState.Location = new System.Drawing.Point(115, 20);
            this.labelTaskState.Name = "labelTaskState";
            this.labelTaskState.Size = new System.Drawing.Size(521, 17);
            this.labelTaskState.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "State";
            // 
            // comboTask
            // 
            this.comboTask.FormattingEnabled = true;
            this.comboTask.Location = new System.Drawing.Point(12, 17);
            this.comboTask.Name = "comboTask";
            this.comboTask.Size = new System.Drawing.Size(56, 20);
            this.comboTask.TabIndex = 0;
            this.comboTask.SelectedIndexChanged += new System.EventHandler(this.comboTask_SelectedIndexChanged);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(427, 48);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(121, 30);
            this.btnMonitor.TabIndex = 20;
            this.btnMonitor.Text = "Signal Monitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.Scope_Click);
            // 
            // groupHome
            // 
            this.groupHome.Controls.Add(this.StopBtn);
            this.groupHome.Controls.Add(this.HomeBtn);
            this.groupHome.Location = new System.Drawing.Point(244, 11);
            this.groupHome.Name = "groupHome";
            this.groupHome.Size = new System.Drawing.Size(177, 65);
            this.groupHome.TabIndex = 7;
            this.groupHome.TabStop = false;
            this.groupHome.Text = "Home Status";
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(94, 28);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(66, 23);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "STOP";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(22, 28);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(66, 23);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus,
            this.labelMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(43, 17);
            this.labelStatus.Text = "Status";
            this.labelStatus.Click += new System.EventHandler(this.labelMessage_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(61, 17);
            this.labelMessage.Text = "Message";
            this.labelMessage.Click += new System.EventHandler(this.laebelMessage_Click);
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(427, 12);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(121, 30);
            this.btnGenerator.TabIndex = 21;
            this.btnGenerator.Text = "Signal Generator";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 48);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(144, 10);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(100, 100);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHostJoyStick";
            this.elementHost1.Child = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 396);
            this.Controls.Add(this.btnGenerator);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupHome);
            this.Controls.Add(this.groupTask);
            this.Controls.Add(this.groupAxis);
            this.Controls.Add(this.groupController);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formGUI_FormClosing);
            this.Load += new System.EventHandler(this.formGUI_Load);
            this.groupController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledConnection)).EndInit();
            this.groupAxis.ResumeLayout(false);
            this.groupAxis.PerformLayout();
            this.tabControlAxisMotion.ResumeLayout(false);
            this.QuickRunTab.ResumeLayout(false);
            this.groupFreerun.ResumeLayout(false);
            this.groupFreerun.PerformLayout();
            this.FreeRunTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.velocityEditArray.ItemTemplate)).EndInit();
            this.groupAxisSelection.ResumeLayout(false);
            this.groupAxisSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchArrayAxisEnable.ItemTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledArrayAxisEnabled.ItemTemplate)).EndInit();
            this.groupAxisState.ResumeLayout(false);
            this.groupAxisState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAxisDiag)).EndInit();
            this.groupTask.ResumeLayout(false);
            this.groupTask.PerformLayout();
            this.groupProgram.ResumeLayout(false);
            this.groupProgram.PerformLayout();
            this.groupHome.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConnectController;
		private System.Windows.Forms.GroupBox groupController;
		private System.Windows.Forms.GroupBox groupAxis;
		private System.Windows.Forms.GroupBox groupTask;
		private System.Windows.Forms.Button ButtonEnableAxis;
		private System.Windows.Forms.Button ButtonFreerunCCW;
		private System.Windows.Forms.Button ButtonFreerunCW;
		private System.Windows.Forms.Button ButtonDisableAxis;
		private System.Windows.Forms.ComboBox comboTask;
		private System.Windows.Forms.Button buttonRunProgram;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelTaskState;
		private System.Windows.Forms.Button buttonStopProgram;
		private System.Windows.Forms.GroupBox groupProgram;
		private System.Windows.Forms.GroupBox groupFreerun;
		private System.Windows.Forms.TextBox textFreerunSpeed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textProgram;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.GroupBox groupHome;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.GroupBox groupAxisState;
        private System.Windows.Forms.Label labelAxisFault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAxisHomed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ToolStripStatusLabel labelMessage;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button btnResetController;
        private System.Windows.Forms.Button btnDisconnectController;
        private NationalInstruments.UI.WindowsForms.Led ledConnection;
        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.CheckedListBox checkedListBoxAxis;
        private System.Windows.Forms.DataGridView dataGridViewAxisDiag;
        private System.Windows.Forms.TabControl tabControlAxisMotion;
        private System.Windows.Forms.TabPage QuickRunTab;
        private System.Windows.Forms.TabPage FreeRunTab;
        private System.Windows.Forms.TabPage LinearMotionTab;
        private System.Windows.Forms.GroupBox groupAxisSelection;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.Label velLabel;
        private System.Windows.Forms.Label posLabel;
        private System.Windows.Forms.Label axisLabel;
        private NationalInstruments.UI.WindowsForms.LedArray ledArrayAxisEnabled;
        private NationalInstruments.UI.WindowsForms.SwitchArray switchArrayAxisEnable;
        private NationalInstruments.UI.WindowsForms.NumericEditArray velocityEditArray;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}

