namespace GUI
{
    partial class MonitorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskTreeView = new System.Windows.Forms.TreeView();
            this.globalContinuousAIWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.channelLegend = new NationalInstruments.UI.WindowsForms.Legend();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor5 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor6 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor7 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor8 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor1 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor2 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor3 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor4 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPowerSpectrumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timingParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.rateNumeric = new System.Windows.Forms.NumericUpDown();
            this.samplesLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.samplesPerChannelNumeric = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalContinuousAIWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelLegend)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.timingParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesPerChannelNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.globalContinuousAIWaveformGraph);
            this.splitContainer1.Panel2.Controls.Add(this.channelLegend);
            this.splitContainer1.Size = new System.Drawing.Size(800, 384);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus,
            this.labelMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(253, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(43, 17);
            this.labelStatus.Text = "Status";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(61, 17);
            this.labelMessage.Text = "Message";
            // 
            // taskTreeView
            // 
            this.taskTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskTreeView.CheckBoxes = true;
            this.taskTreeView.Location = new System.Drawing.Point(3, 3);
            this.taskTreeView.Name = "taskTreeView";
            this.taskTreeView.Size = new System.Drawing.Size(253, 256);
            this.taskTreeView.TabIndex = 0;
            this.taskTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.taskTreeView_AfterSelect);
            // 
            // globalContinuousAIWaveformGraph
            // 
            this.globalContinuousAIWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.globalContinuousAIWaveformGraph.Location = new System.Drawing.Point(0, 0);
            this.globalContinuousAIWaveformGraph.Name = "globalContinuousAIWaveformGraph";
            this.globalContinuousAIWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.globalContinuousAIWaveformGraph.Size = new System.Drawing.Size(543, 339);
            this.globalContinuousAIWaveformGraph.TabIndex = 4;
            this.globalContinuousAIWaveformGraph.TabStop = false;
            this.globalContinuousAIWaveformGraph.UseColorGenerator = true;
            this.globalContinuousAIWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.globalContinuousAIWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.ToolTipsEnabled = true;
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // channelLegend
            // 
            this.channelLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.channelLegend.Location = new System.Drawing.Point(0, 339);
            this.channelLegend.Name = "channelLegend";
            this.channelLegend.Size = new System.Drawing.Size(543, 45);
            this.channelLegend.TabIndex = 5;
            this.channelLegend.TabStop = false;
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(108, 22);
            this.toolStripLabel5.Text = "InteractionMode:";
            // 
            // toolStripPropertyEditor5
            // 
            this.toolStripPropertyEditor5.AutoSize = false;
            this.toolStripPropertyEditor5.Name = "toolStripPropertyEditor5";
            this.toolStripPropertyEditor5.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor5.Size = new System.Drawing.Size(120, 23);
            this.toolStripPropertyEditor5.Source = new NationalInstruments.UI.PropertyEditorSource(this.globalContinuousAIWaveformGraph, "InteractionMode");
            this.toolStripPropertyEditor5.Text = "ZoomX, ZoomY, ZoomAroundPoint, PanX, PanY, DragCursor, DragAnnotationCaption";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel6.Text = "Cursors:";
            // 
            // toolStripPropertyEditor6
            // 
            this.toolStripPropertyEditor6.AutoSize = false;
            this.toolStripPropertyEditor6.Name = "toolStripPropertyEditor6";
            this.toolStripPropertyEditor6.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor6.Size = new System.Drawing.Size(120, 23);
            this.toolStripPropertyEditor6.Source = new NationalInstruments.UI.PropertyEditorSource(this.globalContinuousAIWaveformGraph, "Cursors");
            this.toolStripPropertyEditor6.Text = "(集合)";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel7.Text = "Annotations:";
            // 
            // toolStripPropertyEditor7
            // 
            this.toolStripPropertyEditor7.AutoSize = false;
            this.toolStripPropertyEditor7.Name = "toolStripPropertyEditor7";
            this.toolStripPropertyEditor7.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor7.Size = new System.Drawing.Size(120, 17);
            this.toolStripPropertyEditor7.Text = "(集合)";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(39, 17);
            this.toolStripLabel8.Text = "Plots:";
            // 
            // toolStripPropertyEditor8
            // 
            this.toolStripPropertyEditor8.AutoSize = false;
            this.toolStripPropertyEditor8.Name = "toolStripPropertyEditor8";
            this.toolStripPropertyEditor8.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor8.Size = new System.Drawing.Size(120, 17);
            this.toolStripPropertyEditor8.Source = new NationalInstruments.UI.PropertyEditorSource(this.globalContinuousAIWaveformGraph, "Plots");
            this.toolStripPropertyEditor8.Text = "(集合)";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(108, 22);
            this.toolStripLabel1.Text = "InteractionMode:";
            // 
            // toolStripPropertyEditor1
            // 
            this.toolStripPropertyEditor1.AutoSize = false;
            this.toolStripPropertyEditor1.Name = "toolStripPropertyEditor1";
            this.toolStripPropertyEditor1.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor1.Size = new System.Drawing.Size(120, 23);
            this.toolStripPropertyEditor1.Source = new NationalInstruments.UI.PropertyEditorSource(this.globalContinuousAIWaveformGraph, "InteractionMode");
            this.toolStripPropertyEditor1.Text = "ZoomX, ZoomY, ZoomAroundPoint, PanX, PanY, DragCursor, DragAnnotationCaption";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel2.Text = "Cursors:";
            // 
            // toolStripPropertyEditor2
            // 
            this.toolStripPropertyEditor2.AutoSize = false;
            this.toolStripPropertyEditor2.Name = "toolStripPropertyEditor2";
            this.toolStripPropertyEditor2.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor2.Size = new System.Drawing.Size(120, 23);
            this.toolStripPropertyEditor2.Source = new NationalInstruments.UI.PropertyEditorSource(this.globalContinuousAIWaveformGraph, "Cursors");
            this.toolStripPropertyEditor2.Text = "(集合)";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel3.Text = "Annotations:";
            // 
            // toolStripPropertyEditor3
            // 
            this.toolStripPropertyEditor3.AutoSize = false;
            this.toolStripPropertyEditor3.Name = "toolStripPropertyEditor3";
            this.toolStripPropertyEditor3.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor3.Size = new System.Drawing.Size(120, 17);
            this.toolStripPropertyEditor3.Text = "(集合)";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(39, 17);
            this.toolStripLabel4.Text = "Plots:";
            // 
            // toolStripPropertyEditor4
            // 
            this.toolStripPropertyEditor4.AutoSize = false;
            this.toolStripPropertyEditor4.Name = "toolStripPropertyEditor4";
            this.toolStripPropertyEditor4.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor4.Size = new System.Drawing.Size(120, 17);
            this.toolStripPropertyEditor4.Source = new NationalInstruments.UI.PropertyEditorSource(this.globalContinuousAIWaveformGraph, "Plots");
            this.toolStripPropertyEditor4.Text = "(集合)";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPowerSpectrumToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(207, 48);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // showPowerSpectrumToolStripMenuItem
            // 
            this.showPowerSpectrumToolStripMenuItem.Name = "showPowerSpectrumToolStripMenuItem";
            this.showPowerSpectrumToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.showPowerSpectrumToolStripMenuItem.Text = "Show power spectrum";
            this.showPowerSpectrumToolStripMenuItem.Click += new System.EventHandler(this.showPowerSpectrumToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // timingParametersGroupBox
            // 
            this.timingParametersGroupBox.Controls.Add(this.rateNumeric);
            this.timingParametersGroupBox.Controls.Add(this.samplesLabel);
            this.timingParametersGroupBox.Controls.Add(this.rateLabel);
            this.timingParametersGroupBox.Controls.Add(this.samplesPerChannelNumeric);
            this.timingParametersGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timingParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.timingParametersGroupBox.Location = new System.Drawing.Point(0, 262);
            this.timingParametersGroupBox.Name = "timingParametersGroupBox";
            this.timingParametersGroupBox.Size = new System.Drawing.Size(253, 100);
            this.timingParametersGroupBox.TabIndex = 6;
            this.timingParametersGroupBox.TabStop = false;
            this.timingParametersGroupBox.Text = "Timing Parameters";
            // 
            // rateNumeric
            // 
            this.rateNumeric.DecimalPlaces = 2;
            this.rateNumeric.Location = new System.Drawing.Point(129, 59);
            this.rateNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rateNumeric.Name = "rateNumeric";
            this.rateNumeric.Size = new System.Drawing.Size(115, 21);
            this.rateNumeric.TabIndex = 3;
            this.rateNumeric.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // samplesLabel
            // 
            this.samplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.samplesLabel.Location = new System.Drawing.Point(19, 28);
            this.samplesLabel.Name = "samplesLabel";
            this.samplesLabel.Size = new System.Drawing.Size(104, 17);
            this.samplesLabel.TabIndex = 0;
            this.samplesLabel.Text = "Samples/Channel:";
            // 
            // rateLabel
            // 
            this.rateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rateLabel.Location = new System.Drawing.Point(19, 62);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(67, 18);
            this.rateLabel.TabIndex = 2;
            this.rateLabel.Text = "Rate (Hz):";
            // 
            // samplesPerChannelNumeric
            // 
            this.samplesPerChannelNumeric.Location = new System.Drawing.Point(129, 24);
            this.samplesPerChannelNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.samplesPerChannelNumeric.Name = "samplesPerChannelNumeric";
            this.samplesPerChannelNumeric.Size = new System.Drawing.Size(115, 21);
            this.samplesPerChannelNumeric.TabIndex = 1;
            this.samplesPerChannelNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timingParametersGroupBox);
            this.panel1.Controls.Add(this.taskTreeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 362);
            this.panel1.TabIndex = 2;
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MonitorForm";
            this.Text = "Monitor Form";
            this.Load += new System.EventHandler(this.MonitorForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalContinuousAIWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelLegend)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.timingParametersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesPerChannelNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView taskTreeView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ToolStripStatusLabel labelMessage;
        private NationalInstruments.UI.WindowsForms.WaveformGraph globalContinuousAIWaveformGraph;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WindowsForms.Legend channelLegend;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showPowerSpectrumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox timingParametersGroupBox;
        private System.Windows.Forms.NumericUpDown rateNumeric;
        private System.Windows.Forms.Label samplesLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.NumericUpDown samplesPerChannelNumeric;
    }
}