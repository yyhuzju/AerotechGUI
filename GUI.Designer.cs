namespace GUI
{
	partial class formGUI
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
            this.buttonConnectController = new System.Windows.Forms.Button();
            this.checkControllerConnected = new System.Windows.Forms.CheckBox();
            this.groupController = new System.Windows.Forms.GroupBox();
            this.groupAxis = new System.Windows.Forms.GroupBox();
            this.groupFreerun = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textFreerunSpeed = new System.Windows.Forms.TextBox();
            this.ButtonFreerunCCW = new System.Windows.Forms.Button();
            this.ButtonFreerunCW = new System.Windows.Forms.Button();
            this.groupAxisState = new System.Windows.Forms.GroupBox();
            this.labelAxisFault = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAxisHomed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAxisSpeed = new System.Windows.Forms.Label();
            this.labelAxisPosition = new System.Windows.Forms.Label();
            this.labelAxisState = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonDisableAxis = new System.Windows.Forms.Button();
            this.ButtonEnableAxis = new System.Windows.Forms.Button();
            this.comboAxis = new System.Windows.Forms.ComboBox();
            this.groupTask = new System.Windows.Forms.GroupBox();
            this.groupProgram = new System.Windows.Forms.GroupBox();
            this.textProgram = new System.Windows.Forms.TextBox();
            this.buttonStopProgram = new System.Windows.Forms.Button();
            this.buttonRunProgram = new System.Windows.Forms.Button();
            this.groupGenericString = new System.Windows.Forms.GroupBox();
            this.textGenericString = new System.Windows.Forms.TextBox();
            this.buttonExecuteGenericString = new System.Windows.Forms.Button();
            this.labelTaskState = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboTask = new System.Windows.Forms.ComboBox();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.groupGlobalDoubles = new System.Windows.Forms.GroupBox();
            this.buttonUpdateGlobalDoubles = new System.Windows.Forms.Button();
            this.listGlobalDouble = new System.Windows.Forms.ListBox();
            this.groupErrorMessage = new System.Windows.Forms.GroupBox();
            this.buttonClearErrorMessage = new System.Windows.Forms.Button();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.groupController.SuspendLayout();
            this.groupAxis.SuspendLayout();
            this.groupFreerun.SuspendLayout();
            this.groupAxisState.SuspendLayout();
            this.groupTask.SuspendLayout();
            this.groupProgram.SuspendLayout();
            this.groupGenericString.SuspendLayout();
            this.groupStatus.SuspendLayout();
            this.groupGlobalDoubles.SuspendLayout();
            this.groupErrorMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnectController
            // 
            this.buttonConnectController.Location = new System.Drawing.Point(41, 27);
            this.buttonConnectController.Name = "buttonConnectController";
            this.buttonConnectController.Size = new System.Drawing.Size(58, 25);
            this.buttonConnectController.TabIndex = 0;
            this.buttonConnectController.Text = "Connect";
            this.buttonConnectController.UseVisualStyleBackColor = true;
            this.buttonConnectController.Click += new System.EventHandler(this.buttonConnectController_Click);
            // 
            // checkControllerConnected
            // 
            this.checkControllerConnected.AutoSize = true;
            this.checkControllerConnected.Enabled = false;
            this.checkControllerConnected.Location = new System.Drawing.Point(120, 32);
            this.checkControllerConnected.Name = "checkControllerConnected";
            this.checkControllerConnected.Size = new System.Drawing.Size(78, 16);
            this.checkControllerConnected.TabIndex = 1;
            this.checkControllerConnected.Text = "Connected";
            this.checkControllerConnected.UseVisualStyleBackColor = true;
            // 
            // groupController
            // 
            this.groupController.Controls.Add(this.buttonConnectController);
            this.groupController.Controls.Add(this.checkControllerConnected);
            this.groupController.Location = new System.Drawing.Point(12, 11);
            this.groupController.Name = "groupController";
            this.groupController.Size = new System.Drawing.Size(455, 66);
            this.groupController.TabIndex = 3;
            this.groupController.TabStop = false;
            this.groupController.Text = "Controller";
            // 
            // groupAxis
            // 
            this.groupAxis.Controls.Add(this.groupFreerun);
            this.groupAxis.Controls.Add(this.groupAxisState);
            this.groupAxis.Controls.Add(this.ButtonDisableAxis);
            this.groupAxis.Controls.Add(this.ButtonEnableAxis);
            this.groupAxis.Controls.Add(this.comboAxis);
            this.groupAxis.Location = new System.Drawing.Point(12, 82);
            this.groupAxis.Name = "groupAxis";
            this.groupAxis.Size = new System.Drawing.Size(455, 99);
            this.groupAxis.TabIndex = 4;
            this.groupAxis.TabStop = false;
            this.groupAxis.Text = "Axis";
            // 
            // groupFreerun
            // 
            this.groupFreerun.Controls.Add(this.label1);
            this.groupFreerun.Controls.Add(this.textFreerunSpeed);
            this.groupFreerun.Controls.Add(this.ButtonFreerunCCW);
            this.groupFreerun.Controls.Add(this.ButtonFreerunCW);
            this.groupFreerun.Location = new System.Drawing.Point(106, 15);
            this.groupFreerun.Name = "groupFreerun";
            this.groupFreerun.Size = new System.Drawing.Size(98, 70);
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
            // textFreerunSpeed
            // 
            this.textFreerunSpeed.Location = new System.Drawing.Point(52, 18);
            this.textFreerunSpeed.Name = "textFreerunSpeed";
            this.textFreerunSpeed.Size = new System.Drawing.Size(40, 21);
            this.textFreerunSpeed.TabIndex = 9;
            this.textFreerunSpeed.Text = "10";
            // 
            // ButtonFreerunCCW
            // 
            this.ButtonFreerunCCW.Location = new System.Drawing.Point(52, 47);
            this.ButtonFreerunCCW.Name = "ButtonFreerunCCW";
            this.ButtonFreerunCCW.Size = new System.Drawing.Size(40, 22);
            this.ButtonFreerunCCW.TabIndex = 8;
            this.ButtonFreerunCCW.Text = "CCW";
            this.ButtonFreerunCCW.UseVisualStyleBackColor = true;
            this.ButtonFreerunCCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFreerunCCW_MouseDown);
            this.ButtonFreerunCCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonFreerunCCW_MouseUp);
            // 
            // ButtonFreerunCW
            // 
            this.ButtonFreerunCW.Location = new System.Drawing.Point(3, 47);
            this.ButtonFreerunCW.Name = "ButtonFreerunCW";
            this.ButtonFreerunCW.Size = new System.Drawing.Size(40, 22);
            this.ButtonFreerunCW.TabIndex = 7;
            this.ButtonFreerunCW.Text = "CW";
            this.ButtonFreerunCW.UseVisualStyleBackColor = true;
            this.ButtonFreerunCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFreerunCW_MouseDown);
            this.ButtonFreerunCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonFreerunCW_MouseUp);
            // 
            // groupAxisState
            // 
            this.groupAxisState.Controls.Add(this.labelAxisFault);
            this.groupAxisState.Controls.Add(this.label2);
            this.groupAxisState.Controls.Add(this.labelAxisHomed);
            this.groupAxisState.Controls.Add(this.label3);
            this.groupAxisState.Controls.Add(this.labelAxisSpeed);
            this.groupAxisState.Controls.Add(this.labelAxisPosition);
            this.groupAxisState.Controls.Add(this.labelAxisState);
            this.groupAxisState.Controls.Add(this.label6);
            this.groupAxisState.Controls.Add(this.label5);
            this.groupAxisState.Controls.Add(this.label4);
            this.groupAxisState.Location = new System.Drawing.Point(210, 15);
            this.groupAxisState.Name = "groupAxisState";
            this.groupAxisState.Size = new System.Drawing.Size(228, 70);
            this.groupAxisState.TabIndex = 16;
            this.groupAxisState.TabStop = false;
            this.groupAxisState.Text = "Axis State";
            // 
            // labelAxisFault
            // 
            this.labelAxisFault.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAxisFault.Location = new System.Drawing.Point(179, 51);
            this.labelAxisFault.Name = "labelAxisFault";
            this.labelAxisFault.Size = new System.Drawing.Size(39, 16);
            this.labelAxisFault.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fault";
            // 
            // labelAxisHomed
            // 
            this.labelAxisHomed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAxisHomed.Location = new System.Drawing.Point(179, 33);
            this.labelAxisHomed.Name = "labelAxisHomed";
            this.labelAxisHomed.Size = new System.Drawing.Size(39, 16);
            this.labelAxisHomed.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Homed";
            // 
            // labelAxisSpeed
            // 
            this.labelAxisSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAxisSpeed.Location = new System.Drawing.Point(56, 49);
            this.labelAxisSpeed.Name = "labelAxisSpeed";
            this.labelAxisSpeed.Size = new System.Drawing.Size(54, 16);
            this.labelAxisSpeed.TabIndex = 14;
            // 
            // labelAxisPosition
            // 
            this.labelAxisPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAxisPosition.Location = new System.Drawing.Point(56, 28);
            this.labelAxisPosition.Name = "labelAxisPosition";
            this.labelAxisPosition.Size = new System.Drawing.Size(54, 16);
            this.labelAxisPosition.TabIndex = 13;
            // 
            // labelAxisState
            // 
            this.labelAxisState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAxisState.Location = new System.Drawing.Point(179, 15);
            this.labelAxisState.Name = "labelAxisState";
            this.labelAxisState.Size = new System.Drawing.Size(39, 16);
            this.labelAxisState.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enabled";
            // 
            // ButtonDisableAxis
            // 
            this.ButtonDisableAxis.Location = new System.Drawing.Point(43, 62);
            this.ButtonDisableAxis.Name = "ButtonDisableAxis";
            this.ButtonDisableAxis.Size = new System.Drawing.Size(56, 23);
            this.ButtonDisableAxis.TabIndex = 5;
            this.ButtonDisableAxis.Text = "Disable";
            this.ButtonDisableAxis.UseVisualStyleBackColor = true;
            this.ButtonDisableAxis.Click += new System.EventHandler(this.buttonDisableAxis_Click);
            // 
            // ButtonEnableAxis
            // 
            this.ButtonEnableAxis.Location = new System.Drawing.Point(43, 38);
            this.ButtonEnableAxis.Name = "ButtonEnableAxis";
            this.ButtonEnableAxis.Size = new System.Drawing.Size(56, 22);
            this.ButtonEnableAxis.TabIndex = 4;
            this.ButtonEnableAxis.Text = "Enable";
            this.ButtonEnableAxis.UseVisualStyleBackColor = true;
            this.ButtonEnableAxis.Click += new System.EventHandler(this.buttonEnableAxis_Click);
            // 
            // comboAxis
            // 
            this.comboAxis.FormattingEnabled = true;
            this.comboAxis.Location = new System.Drawing.Point(42, 13);
            this.comboAxis.Name = "comboAxis";
            this.comboAxis.Size = new System.Drawing.Size(58, 20);
            this.comboAxis.TabIndex = 3;
            this.comboAxis.SelectedIndexChanged += new System.EventHandler(this.comboAxis_SelectedIndexChanged);
            // 
            // groupTask
            // 
            this.groupTask.Controls.Add(this.groupProgram);
            this.groupTask.Controls.Add(this.groupGenericString);
            this.groupTask.Controls.Add(this.labelTaskState);
            this.groupTask.Controls.Add(this.label9);
            this.groupTask.Controls.Add(this.comboTask);
            this.groupTask.Location = new System.Drawing.Point(12, 186);
            this.groupTask.Name = "groupTask";
            this.groupTask.Size = new System.Drawing.Size(455, 182);
            this.groupTask.TabIndex = 5;
            this.groupTask.TabStop = false;
            this.groupTask.Text = "Task";
            // 
            // groupProgram
            // 
            this.groupProgram.Controls.Add(this.textProgram);
            this.groupProgram.Controls.Add(this.buttonStopProgram);
            this.groupProgram.Controls.Add(this.buttonRunProgram);
            this.groupProgram.Location = new System.Drawing.Point(36, 109);
            this.groupProgram.Name = "groupProgram";
            this.groupProgram.Size = new System.Drawing.Size(402, 67);
            this.groupProgram.TabIndex = 16;
            this.groupProgram.TabStop = false;
            this.groupProgram.Text = "Program";
            // 
            // textProgram
            // 
            this.textProgram.Location = new System.Drawing.Point(84, 18);
            this.textProgram.Name = "textProgram";
            this.textProgram.Size = new System.Drawing.Size(308, 21);
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
            // groupGenericString
            // 
            this.groupGenericString.Controls.Add(this.textGenericString);
            this.groupGenericString.Controls.Add(this.buttonExecuteGenericString);
            this.groupGenericString.Location = new System.Drawing.Point(38, 48);
            this.groupGenericString.Name = "groupGenericString";
            this.groupGenericString.Size = new System.Drawing.Size(400, 45);
            this.groupGenericString.TabIndex = 15;
            this.groupGenericString.TabStop = false;
            this.groupGenericString.Text = "Generic String";
            // 
            // textGenericString
            // 
            this.textGenericString.Location = new System.Drawing.Point(85, 19);
            this.textGenericString.Name = "textGenericString";
            this.textGenericString.Size = new System.Drawing.Size(305, 21);
            this.textGenericString.TabIndex = 6;
            this.textGenericString.Text = "$global[1] = 1";
            // 
            // buttonExecuteGenericString
            // 
            this.buttonExecuteGenericString.Location = new System.Drawing.Point(4, 18);
            this.buttonExecuteGenericString.Name = "buttonExecuteGenericString";
            this.buttonExecuteGenericString.Size = new System.Drawing.Size(56, 19);
            this.buttonExecuteGenericString.TabIndex = 5;
            this.buttonExecuteGenericString.Text = "Execute";
            this.buttonExecuteGenericString.UseVisualStyleBackColor = true;
            this.buttonExecuteGenericString.Click += new System.EventHandler(this.buttonExecuteGenericString_Click);
            // 
            // labelTaskState
            // 
            this.labelTaskState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTaskState.Location = new System.Drawing.Point(158, 20);
            this.labelTaskState.Name = "labelTaskState";
            this.labelTaskState.Size = new System.Drawing.Size(162, 17);
            this.labelTaskState.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "State";
            // 
            // comboTask
            // 
            this.comboTask.FormattingEnabled = true;
            this.comboTask.Location = new System.Drawing.Point(42, 18);
            this.comboTask.Name = "comboTask";
            this.comboTask.Size = new System.Drawing.Size(57, 20);
            this.comboTask.TabIndex = 0;
            this.comboTask.SelectedIndexChanged += new System.EventHandler(this.comboTask_SelectedIndexChanged);
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.groupGlobalDoubles);
            this.groupStatus.Controls.Add(this.groupErrorMessage);
            this.groupStatus.Location = new System.Drawing.Point(12, 374);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(455, 163);
            this.groupStatus.TabIndex = 6;
            this.groupStatus.TabStop = false;
            this.groupStatus.Text = "Status";
            // 
            // groupGlobalDoubles
            // 
            this.groupGlobalDoubles.Controls.Add(this.buttonUpdateGlobalDoubles);
            this.groupGlobalDoubles.Controls.Add(this.listGlobalDouble);
            this.groupGlobalDoubles.Location = new System.Drawing.Point(34, 17);
            this.groupGlobalDoubles.Name = "groupGlobalDoubles";
            this.groupGlobalDoubles.Size = new System.Drawing.Size(100, 140);
            this.groupGlobalDoubles.TabIndex = 19;
            this.groupGlobalDoubles.TabStop = false;
            this.groupGlobalDoubles.Text = "Global Doubles";
            // 
            // buttonUpdateGlobalDoubles
            // 
            this.buttonUpdateGlobalDoubles.Location = new System.Drawing.Point(7, 113);
            this.buttonUpdateGlobalDoubles.Name = "buttonUpdateGlobalDoubles";
            this.buttonUpdateGlobalDoubles.Size = new System.Drawing.Size(85, 21);
            this.buttonUpdateGlobalDoubles.TabIndex = 4;
            this.buttonUpdateGlobalDoubles.Text = "Update";
            this.buttonUpdateGlobalDoubles.UseVisualStyleBackColor = true;
            this.buttonUpdateGlobalDoubles.Click += new System.EventHandler(this.buttonUpdateGlobalDoubles_Click);
            // 
            // listGlobalDouble
            // 
            this.listGlobalDouble.FormattingEnabled = true;
            this.listGlobalDouble.ItemHeight = 12;
            this.listGlobalDouble.Location = new System.Drawing.Point(6, 32);
            this.listGlobalDouble.Name = "listGlobalDouble";
            this.listGlobalDouble.Size = new System.Drawing.Size(88, 76);
            this.listGlobalDouble.TabIndex = 3;
            // 
            // groupErrorMessage
            // 
            this.groupErrorMessage.Controls.Add(this.buttonClearErrorMessage);
            this.groupErrorMessage.Controls.Add(this.labelErrorMessage);
            this.groupErrorMessage.Location = new System.Drawing.Point(167, 17);
            this.groupErrorMessage.Name = "groupErrorMessage";
            this.groupErrorMessage.Size = new System.Drawing.Size(271, 66);
            this.groupErrorMessage.TabIndex = 18;
            this.groupErrorMessage.TabStop = false;
            this.groupErrorMessage.Text = "Error Message";
            // 
            // buttonClearErrorMessage
            // 
            this.buttonClearErrorMessage.Location = new System.Drawing.Point(6, 42);
            this.buttonClearErrorMessage.Name = "buttonClearErrorMessage";
            this.buttonClearErrorMessage.Size = new System.Drawing.Size(53, 19);
            this.buttonClearErrorMessage.TabIndex = 17;
            this.buttonClearErrorMessage.Text = "Clear";
            this.buttonClearErrorMessage.UseVisualStyleBackColor = true;
            this.buttonClearErrorMessage.Click += new System.EventHandler(this.buttonClearErrorMessage_Click);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelErrorMessage.Location = new System.Drawing.Point(6, 19);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(259, 19);
            this.labelErrorMessage.TabIndex = 14;
            // 
            // formGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 549);
            this.Controls.Add(this.groupStatus);
            this.Controls.Add(this.groupTask);
            this.Controls.Add(this.groupAxis);
            this.Controls.Add(this.groupController);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formGUI";
            this.Text = "GUI Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formGUI_FormClosing);
            this.Load += new System.EventHandler(this.formGUI_Load);
            this.groupController.ResumeLayout(false);
            this.groupController.PerformLayout();
            this.groupAxis.ResumeLayout(false);
            this.groupFreerun.ResumeLayout(false);
            this.groupFreerun.PerformLayout();
            this.groupAxisState.ResumeLayout(false);
            this.groupAxisState.PerformLayout();
            this.groupTask.ResumeLayout(false);
            this.groupTask.PerformLayout();
            this.groupProgram.ResumeLayout(false);
            this.groupProgram.PerformLayout();
            this.groupGenericString.ResumeLayout(false);
            this.groupGenericString.PerformLayout();
            this.groupStatus.ResumeLayout(false);
            this.groupGlobalDoubles.ResumeLayout(false);
            this.groupErrorMessage.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonConnectController;
		private System.Windows.Forms.CheckBox checkControllerConnected;
		private System.Windows.Forms.GroupBox groupController;
		private System.Windows.Forms.GroupBox groupAxis;
		private System.Windows.Forms.GroupBox groupTask;
		private System.Windows.Forms.GroupBox groupStatus;
		private System.Windows.Forms.Button ButtonEnableAxis;
		private System.Windows.Forms.ComboBox comboAxis;
		private System.Windows.Forms.Button ButtonFreerunCCW;
		private System.Windows.Forms.Button ButtonFreerunCW;
		private System.Windows.Forms.Button ButtonDisableAxis;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelAxisPosition;
		private System.Windows.Forms.Label labelAxisState;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelAxisSpeed;
		private System.Windows.Forms.ComboBox comboTask;
		private System.Windows.Forms.Button buttonExecuteGenericString;
		private System.Windows.Forms.Button buttonRunProgram;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelTaskState;
		private System.Windows.Forms.Label labelErrorMessage;
		private System.Windows.Forms.ListBox listGlobalDouble;
		private System.Windows.Forms.Button buttonStopProgram;
		private System.Windows.Forms.GroupBox groupProgram;
		private System.Windows.Forms.GroupBox groupGenericString;
		private System.Windows.Forms.Button buttonClearErrorMessage;
		private System.Windows.Forms.GroupBox groupAxisState;
		private System.Windows.Forms.Label labelAxisFault;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelAxisHomed;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupFreerun;
		private System.Windows.Forms.TextBox textFreerunSpeed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupErrorMessage;
		private System.Windows.Forms.GroupBox groupGlobalDoubles;
		private System.Windows.Forms.Button buttonUpdateGlobalDoubles;
		private System.Windows.Forms.TextBox textProgram;
		private System.Windows.Forms.TextBox textGenericString;
	}
}

