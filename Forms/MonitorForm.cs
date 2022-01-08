using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logging;
using NationalInstruments;
using NationalInstruments.UI;
using UIMethods;

namespace GUI
{
    public partial class MonitorForm : Form
    {
        static string dataLoggerFileName = String.Format("Data logging {0}.txt",
                DateTime.UtcNow.ToString("yyyy-MM-dd HH-mm"));
        private TreeNode TaskNode = new TreeNode();
        private TreeNode DeviceNode = new TreeNode();
        private SysLogger sysLogger;
        private string loggerType = "data_logger";
        private Task runningTask;
        private Task continuousTask;
        private AnalogMultiChannelReader analogMultiChannelReader;
        private AsyncCallback callBack;
        private AnalogWaveform<double>[] data;
        public MonitorForm()
        {
            InitializeComponent();
            taskTreeView.LabelEdit = true;
            TaskNode.Text = "Task";
            taskTreeView.Nodes.Add(TaskNode);
            foreach (string s in DaqSystem.Local.Tasks)
            {
                try
                {
                    using (Task t = DaqSystem.Local.LoadTask(s))
                    {
                        t.Control(TaskAction.Verify);

                        if (t.AIChannels.Count > 0 &&
                            t.Timing.SampleQuantityMode == SampleQuantityMode.ContinuousSamples)
                        {
                            TaskNode.Nodes.Add(s);
                        }
                    }
                }
                catch (DaqException ex)
                {
                    UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Error", ex.Message);
                }
                if (TaskNode.Nodes.Count > 0)
                {
                    TaskNode.Expand();
                    taskTreeView.SelectedNode = TaskNode.Nodes[0];
                }
            }
            
            DeviceNode.Text = "Device";
            taskTreeView.Nodes.Add(DeviceNode);
            foreach (string s in DaqSystem.Local.Devices)
            {
                try
                {
                    TreeNode deviceNode = new TreeNode(s);
                    DeviceNode.Nodes.Add(deviceNode);
                    foreach(string str in DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External))
                        deviceNode.Nodes.Add(str);
                }
                catch (DaqException)
                {
                    // Ignore invalid tasks
                }
                if (DeviceNode.Nodes.Count > 0)
                {
                    DeviceNode.Expand();
                    DeviceNode.Nodes[0].Expand();
                }
            }
        }
        private void MonitorForm_Load(object sender, EventArgs e)
        {
            this.globalContinuousAIWaveformGraph.ContextMenuStrip = this.contextMenuStrip;
            loggerType = "data_logger";
            sysLogger = new SysLogger(loggerType, dataLoggerFileName);
            string message = "Monitor started";
            UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Info", message);
        }
        #region methods
        #endregion
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (continuousTask != null)
                {
                    runningTask = null;
                    continuousTask.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        private void taskTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (taskTreeView.SelectedNode.Parent == TaskNode)
            {
                channelLegend.Items.Clear();
                globalContinuousAIWaveformGraph.ClearData();
                globalContinuousAIWaveformGraph.Plots.Clear();

                try
                {
                    string taskName = taskTreeView.SelectedNode.Text;
                    if (continuousTask != null)
                        continuousTask.Dispose();
                    continuousTask = DaqSystem.Local.LoadTask(taskName);

                    SetupUI();

                    runningTask = continuousTask;
                    analogMultiChannelReader = new AnalogMultiChannelReader(continuousTask.Stream);

                    callBack = new AsyncCallback(ReadCallBack);

                    analogMultiChannelReader.SynchronizeCallbacks = true;
                    analogMultiChannelReader.BeginReadWaveform(Convert.ToInt32(continuousTask.Timing.SamplesPerChannel), callBack, continuousTask);

                }
                catch (DaqException ex)
                {
                    UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Error", ex.Message);
                    continuousTask.Dispose();
                }
            }
        }
        public void ReadCallBack(IAsyncResult ar)
        {
            try
            {
                if (runningTask != null && runningTask == ar.AsyncState)
                {
                    data = analogMultiChannelReader.EndReadWaveform(ar);

                    globalContinuousAIWaveformGraph.PlotWaveformsAppend(data);

                    analogMultiChannelReader.BeginMemoryOptimizedReadWaveform(Convert.ToInt32(continuousTask.Timing.SamplesPerChannel), callBack, continuousTask, data);
                }
            }
            catch (DaqException ex)
            {
                UIModificationStatic.Logging(this.labelStatus, this.labelMessage, sysLogger, "Error", ex.Message);
                continuousTask.Dispose();
            }
        }
        private void SetupUI()
        {
            continuousTask.Control(TaskAction.Verify);
            int i = 0;
            foreach (AIChannel chan in continuousTask.AIChannels)
            {
                WaveformPlot plot = new WaveformPlot();
                globalContinuousAIWaveformGraph.Plots.Add(plot);
                channelLegend.Items.Add(new LegendItem(plot, chan.VirtualName + ": " + chan.PhysicalName));
                i++;
            }
        }
        private void labelStatus_Click(object sender, EventArgs e)
        {
            UIModificationStatic.ShowLoggerForm(this, sysLogger);
        }

        private void showPowerSpectrumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms["SpectrumForm"];
            if (frm != null && frm.Created)
            {
                frm.Focus();
                return;
            }
            frm = new SpectrumForm();
            frm.Show();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (continuousTask != null)
                continuousTask.Dispose();
            runningTask = null;
        }
    }
}

