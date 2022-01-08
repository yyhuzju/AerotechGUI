using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
// This example only compiles if you install NI-DAQmx support from the Device Drivers CD
using NationalInstruments.DAQmx;
using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.Analysis.Dsp.Filters;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Monitoring;
using NationalInstruments.Analysis.SignalGeneration;
// This example only compiles with Enterprise Analysis
using NationalInstruments.Analysis.SpectralMeasurements;

namespace GUI
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class SpectrumForm : Form
    {
        // This example only compiles if you install NI-DAQmx support from the Device Drivers CD.
        private Task myTask;
        private AnalogSingleChannelReader reader;
        private Task runningTask;

        double samplingRate;
        int samplesPerChannel;

        double[] autoPowerSpectrum;
        double searchFrequency;
        double equivalentNoiseBandwidth;
        double coherentGain;
        double df;

        private NationalInstruments.UI.WindowsForms.WaveformGraph acquiredDataWaveformGraph;
        private NationalInstruments.UI.WindowsForms.WaveformGraph powerSpectrumWaveformGraph;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.Label physicalChannelLabel;
        private System.Windows.Forms.Label samplingRateLabel;
        private System.Windows.Forms.Label samplePerChannelLabel;
        private NationalInstruments.UI.WindowsForms.Switch acquisitionStateSwitch;
        private System.Windows.Forms.ComboBox windowComboBox;
        private System.Windows.Forms.Label windowLabel;
        private System.Windows.Forms.ComboBox unitsComboBox;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.ComboBox scaleComboBox;
        private System.Windows.Forms.Label scaleLabel;
        private NationalInstruments.UI.XYCursor xyCursor;
        private NationalInstruments.UI.WaveformPlot powerSpectrumPlot;
        private NationalInstruments.UI.XAxis powerSpectrumxAxis;
        private NationalInstruments.UI.YAxis powerSpectrumYAxis;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.GroupBox AcquisitionGroupBox;
        private System.Windows.Forms.Label freqPeakLabel;
        private System.Windows.Forms.Label powerPeakLabel;
        private NationalInstruments.UI.WaveformPlot waveformPlot;
        private NationalInstruments.UI.XAxis waveformXAxis;
        private NationalInstruments.UI.YAxis waveformYAxis;
        private System.Windows.Forms.Label acquisitionLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit rateNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit samplesNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit peakPowerNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit peakFrequencyNumericEdit;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public SpectrumForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (myTask != null)
                {
                    runningTask = null;
                    myTask.Dispose();
                }
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
            this.acquiredDataWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.waveformXAxis = new NationalInstruments.UI.XAxis();
            this.waveformYAxis = new NationalInstruments.UI.YAxis();
            this.acquisitionStateSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.powerSpectrumWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.xyCursor = new NationalInstruments.UI.XYCursor();
            this.powerSpectrumPlot = new NationalInstruments.UI.WaveformPlot();
            this.powerSpectrumxAxis = new NationalInstruments.UI.XAxis();
            this.powerSpectrumYAxis = new NationalInstruments.UI.YAxis();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.physicalChannelLabel = new System.Windows.Forms.Label();
            this.samplingRateLabel = new System.Windows.Forms.Label();
            this.samplePerChannelLabel = new System.Windows.Forms.Label();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.windowComboBox = new System.Windows.Forms.ComboBox();
            this.windowLabel = new System.Windows.Forms.Label();
            this.unitsComboBox = new System.Windows.Forms.ComboBox();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.scaleComboBox = new System.Windows.Forms.ComboBox();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.AcquisitionGroupBox = new System.Windows.Forms.GroupBox();
            this.samplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.rateNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.freqPeakLabel = new System.Windows.Forms.Label();
            this.powerPeakLabel = new System.Windows.Forms.Label();
            this.acquisitionLabel = new System.Windows.Forms.Label();
            this.peakPowerNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.peakFrequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.acquiredDataWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquisitionStateSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerSpectrumWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyCursor)).BeginInit();
            this.SettingsGroupBox.SuspendLayout();
            this.AcquisitionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplesNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakPowerNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakFrequencyNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // acquiredDataWaveformGraph
            // 
            this.acquiredDataWaveformGraph.Caption = "Acquired Data";
            this.acquiredDataWaveformGraph.Location = new System.Drawing.Point(192, 16);
            this.acquiredDataWaveformGraph.Name = "acquiredDataWaveformGraph";
            this.acquiredDataWaveformGraph.PlotAreaColor = System.Drawing.Color.White;
            this.acquiredDataWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot});
            this.acquiredDataWaveformGraph.Size = new System.Drawing.Size(456, 216);
            this.acquiredDataWaveformGraph.TabIndex = 2;
            this.acquiredDataWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.waveformXAxis});
            this.acquiredDataWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.waveformYAxis});
            // 
            // waveformPlot
            // 
            this.waveformPlot.LineColor = System.Drawing.Color.Red;
            this.waveformPlot.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.waveformPlot.XAxis = this.waveformXAxis;
            this.waveformPlot.YAxis = this.waveformYAxis;
            // 
            // waveformXAxis
            // 
            this.waveformXAxis.MajorDivisions.GridColor = System.Drawing.Color.DodgerBlue;
            this.waveformXAxis.MajorDivisions.GridVisible = true;
            // 
            // waveformYAxis
            // 
            this.waveformYAxis.Caption = "Volts";
            this.waveformYAxis.MajorDivisions.GridColor = System.Drawing.Color.DodgerBlue;
            this.waveformYAxis.MajorDivisions.GridVisible = true;
            // 
            // acquisitionStateSwitch
            // 
            this.acquisitionStateSwitch.Location = new System.Drawing.Point(120, 408);
            this.acquisitionStateSwitch.Name = "acquisitionStateSwitch";
            this.acquisitionStateSwitch.OffColor = System.Drawing.Color.OrangeRed;
            this.acquisitionStateSwitch.OnColor = System.Drawing.Color.LawnGreen;
            this.acquisitionStateSwitch.Size = new System.Drawing.Size(64, 96);
            this.acquisitionStateSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.acquisitionStateSwitch.TabIndex = 7;
            this.acquisitionStateSwitch.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.acquisitionChanged);
            // 
            // powerSpectrumWaveformGraph
            // 
            this.powerSpectrumWaveformGraph.Caption = "Power Spectrum";
            this.powerSpectrumWaveformGraph.Cursors.AddRange(new NationalInstruments.UI.XYCursor[] {
            this.xyCursor});
            this.powerSpectrumWaveformGraph.Location = new System.Drawing.Point(192, 240);
            this.powerSpectrumWaveformGraph.Name = "powerSpectrumWaveformGraph";
            this.powerSpectrumWaveformGraph.PlotAreaColor = System.Drawing.Color.White;
            this.powerSpectrumWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.powerSpectrumPlot});
            this.powerSpectrumWaveformGraph.Size = new System.Drawing.Size(456, 224);
            this.powerSpectrumWaveformGraph.TabIndex = 5;
            this.powerSpectrumWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.powerSpectrumxAxis});
            this.powerSpectrumWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.powerSpectrumYAxis});
            // 
            // xyCursor
            // 
            this.xyCursor.Color = System.Drawing.Color.SeaGreen;
            this.xyCursor.Plot = this.powerSpectrumPlot;
            // 
            // powerSpectrumPlot
            // 
            this.powerSpectrumPlot.LineColor = System.Drawing.Color.Red;
            this.powerSpectrumPlot.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.powerSpectrumPlot.XAxis = this.powerSpectrumxAxis;
            this.powerSpectrumPlot.YAxis = this.powerSpectrumYAxis;
            // 
            // powerSpectrumxAxis
            // 
            this.powerSpectrumxAxis.Caption = "Hertz";
            this.powerSpectrumxAxis.MajorDivisions.GridColor = System.Drawing.Color.DodgerBlue;
            this.powerSpectrumxAxis.MajorDivisions.GridVisible = true;
            // 
            // powerSpectrumYAxis
            // 
            this.powerSpectrumYAxis.Caption = "Vms";
            this.powerSpectrumYAxis.MajorDivisions.GridColor = System.Drawing.Color.DodgerBlue;
            this.powerSpectrumYAxis.MajorDivisions.GridVisible = true;
            this.powerSpectrumYAxis.MinorDivisions.GridColor = System.Drawing.Color.Chartreuse;
            this.powerSpectrumYAxis.Range = new NationalInstruments.UI.Range(-2D, 8D);
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(24, 40);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(88, 21);
            this.channelTextBox.TabIndex = 1;
            this.channelTextBox.Text = "Dev1/ai0";
            // 
            // physicalChannelLabel
            // 
            this.physicalChannelLabel.Location = new System.Drawing.Point(24, 24);
            this.physicalChannelLabel.Name = "physicalChannelLabel";
            this.physicalChannelLabel.Size = new System.Drawing.Size(96, 16);
            this.physicalChannelLabel.TabIndex = 1;
            this.physicalChannelLabel.Text = "Physical Channel:";
            // 
            // samplingRateLabel
            // 
            this.samplingRateLabel.Location = new System.Drawing.Point(24, 80);
            this.samplingRateLabel.Name = "samplingRateLabel";
            this.samplingRateLabel.Size = new System.Drawing.Size(112, 16);
            this.samplingRateLabel.TabIndex = 3;
            this.samplingRateLabel.Text = "Sampling Rate (Hz):";
            // 
            // samplePerChannelLabel
            // 
            this.samplePerChannelLabel.Location = new System.Drawing.Point(24, 136);
            this.samplePerChannelLabel.Name = "samplePerChannelLabel";
            this.samplePerChannelLabel.Size = new System.Drawing.Size(120, 16);
            this.samplePerChannelLabel.TabIndex = 5;
            this.samplePerChannelLabel.Text = "Samples per Channel";
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.windowComboBox);
            this.SettingsGroupBox.Controls.Add(this.windowLabel);
            this.SettingsGroupBox.Controls.Add(this.unitsComboBox);
            this.SettingsGroupBox.Controls.Add(this.unitsLabel);
            this.SettingsGroupBox.Controls.Add(this.scaleComboBox);
            this.SettingsGroupBox.Controls.Add(this.scaleLabel);
            this.SettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SettingsGroupBox.Location = new System.Drawing.Point(16, 224);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(160, 184);
            this.SettingsGroupBox.TabIndex = 4;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Display Settings";
            // 
            // windowComboBox
            // 
            this.windowComboBox.Items.AddRange(new object[] {
            "Rectangular",
            "Hanning",
            "Hamming",
            "Blackman-Harris",
            "Exact Blackman",
            "Blackman",
            "FlatTop",
            "4Term B-Harris",
            "7Term B-Harris"});
            this.windowComboBox.Location = new System.Drawing.Point(24, 48);
            this.windowComboBox.Name = "windowComboBox";
            this.windowComboBox.Size = new System.Drawing.Size(96, 20);
            this.windowComboBox.TabIndex = 1;
            this.windowComboBox.Text = "FlatTop";
            // 
            // windowLabel
            // 
            this.windowLabel.Location = new System.Drawing.Point(24, 32);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(72, 16);
            this.windowLabel.TabIndex = 0;
            this.windowLabel.Text = "Window";
            // 
            // unitsComboBox
            // 
            this.unitsComboBox.Items.AddRange(new object[] {
            "Vrms",
            "Vrms^2",
            "Vrms/rt(Hz)",
            "Vpk^2/Hz",
            "Vpk",
            "Vpk^2",
            "Vpk/rt(Hz)",
            "Vrms^2/Hz"});
            this.unitsComboBox.Location = new System.Drawing.Point(24, 96);
            this.unitsComboBox.Name = "unitsComboBox";
            this.unitsComboBox.Size = new System.Drawing.Size(96, 20);
            this.unitsComboBox.TabIndex = 3;
            this.unitsComboBox.Text = "Vrms";
            // 
            // unitsLabel
            // 
            this.unitsLabel.Location = new System.Drawing.Point(24, 80);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(40, 16);
            this.unitsLabel.TabIndex = 2;
            this.unitsLabel.Text = "Units";
            // 
            // scaleComboBox
            // 
            this.scaleComboBox.Items.AddRange(new object[] {
            "Linear",
            "dB",
            "dBm"});
            this.scaleComboBox.Location = new System.Drawing.Point(24, 144);
            this.scaleComboBox.Name = "scaleComboBox";
            this.scaleComboBox.Size = new System.Drawing.Size(96, 20);
            this.scaleComboBox.TabIndex = 5;
            this.scaleComboBox.Text = "Linear";
            // 
            // scaleLabel
            // 
            this.scaleLabel.Location = new System.Drawing.Point(24, 128);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(48, 16);
            this.scaleLabel.TabIndex = 4;
            this.scaleLabel.Text = "Scale";
            // 
            // AcquisitionGroupBox
            // 
            this.AcquisitionGroupBox.Controls.Add(this.samplesNumericEdit);
            this.AcquisitionGroupBox.Controls.Add(this.rateNumericEdit);
            this.AcquisitionGroupBox.Controls.Add(this.samplePerChannelLabel);
            this.AcquisitionGroupBox.Controls.Add(this.physicalChannelLabel);
            this.AcquisitionGroupBox.Controls.Add(this.samplingRateLabel);
            this.AcquisitionGroupBox.Controls.Add(this.channelTextBox);
            this.AcquisitionGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AcquisitionGroupBox.Location = new System.Drawing.Point(16, 16);
            this.AcquisitionGroupBox.Name = "AcquisitionGroupBox";
            this.AcquisitionGroupBox.Size = new System.Drawing.Size(160, 192);
            this.AcquisitionGroupBox.TabIndex = 1;
            this.AcquisitionGroupBox.TabStop = false;
            this.AcquisitionGroupBox.Text = "Acquisition Settings";
            // 
            // samplesNumericEdit
            // 
            this.samplesNumericEdit.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval;
            this.samplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.samplesNumericEdit.Location = new System.Drawing.Point(24, 152);
            this.samplesNumericEdit.Name = "samplesNumericEdit";
            this.samplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.samplesNumericEdit.Range = new NationalInstruments.UI.Range(2D, 33554432D);
            this.samplesNumericEdit.Size = new System.Drawing.Size(88, 21);
            this.samplesNumericEdit.TabIndex = 3;
            this.samplesNumericEdit.Value = 1000D;
            // 
            // rateNumericEdit
            // 
            this.rateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.rateNumericEdit.Location = new System.Drawing.Point(24, 96);
            this.rateNumericEdit.Name = "rateNumericEdit";
            this.rateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.rateNumericEdit.Range = new NationalInstruments.UI.Range(1D, 6666666D);
            this.rateNumericEdit.Size = new System.Drawing.Size(88, 21);
            this.rateNumericEdit.TabIndex = 2;
            this.rateNumericEdit.Value = 10000D;
            // 
            // freqPeakLabel
            // 
            this.freqPeakLabel.Location = new System.Drawing.Point(432, 480);
            this.freqPeakLabel.Name = "freqPeakLabel";
            this.freqPeakLabel.Size = new System.Drawing.Size(96, 16);
            this.freqPeakLabel.TabIndex = 0;
            this.freqPeakLabel.Text = "Frequency Peak:";
            // 
            // powerPeakLabel
            // 
            this.powerPeakLabel.Location = new System.Drawing.Point(216, 480);
            this.powerPeakLabel.Name = "powerPeakLabel";
            this.powerPeakLabel.Size = new System.Drawing.Size(72, 16);
            this.powerPeakLabel.TabIndex = 8;
            this.powerPeakLabel.Text = "Power Peak:";
            // 
            // acquisitionLabel
            // 
            this.acquisitionLabel.Location = new System.Drawing.Point(8, 448);
            this.acquisitionLabel.Name = "acquisitionLabel";
            this.acquisitionLabel.Size = new System.Drawing.Size(112, 32);
            this.acquisitionLabel.TabIndex = 6;
            this.acquisitionLabel.Text = "Acquisition ON/OFF";
            // 
            // peakPowerNumericEdit
            // 
            this.peakPowerNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.peakPowerNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.peakPowerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.peakPowerNumericEdit.Location = new System.Drawing.Point(296, 480);
            this.peakPowerNumericEdit.Name = "peakPowerNumericEdit";
            this.peakPowerNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.peakPowerNumericEdit.Size = new System.Drawing.Size(128, 21);
            this.peakPowerNumericEdit.TabIndex = 9;
            this.peakPowerNumericEdit.TabStop = false;
            // 
            // peakFrequencyNumericEdit
            // 
            this.peakFrequencyNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.peakFrequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.peakFrequencyNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.peakFrequencyNumericEdit.Location = new System.Drawing.Point(536, 480);
            this.peakFrequencyNumericEdit.Name = "peakFrequencyNumericEdit";
            this.peakFrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.peakFrequencyNumericEdit.Size = new System.Drawing.Size(112, 21);
            this.peakFrequencyNumericEdit.TabIndex = 1;
            this.peakFrequencyNumericEdit.TabStop = false;
            // 
            // SpectrumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(666, 512);
            this.Controls.Add(this.peakFrequencyNumericEdit);
            this.Controls.Add(this.peakPowerNumericEdit);
            this.Controls.Add(this.acquisitionLabel);
            this.Controls.Add(this.powerPeakLabel);
            this.Controls.Add(this.freqPeakLabel);
            this.Controls.Add(this.powerSpectrumWaveformGraph);
            this.Controls.Add(this.acquisitionStateSwitch);
            this.Controls.Add(this.acquiredDataWaveformGraph);
            this.Controls.Add(this.AcquisitionGroupBox);
            this.Controls.Add(this.SettingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SpectrumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spectrum Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.acquiredDataWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquisitionStateSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerSpectrumWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyCursor)).EndInit();
            this.SettingsGroupBox.ResumeLayout(false);
            this.AcquisitionGroupBox.ResumeLayout(false);
            this.AcquisitionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplesNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakPowerNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakFrequencyNumericEdit)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


        private void myCallback(IAsyncResult ar)
        {
            try
            {
                if (runningTask != null && runningTask == ar.AsyncState)
                {
                    double[] data = reader.EndReadMultiSample(ar);
                    acquiredDataWaveformGraph.PlotY(data);
                    getUnitConvertedAutoPowerSpectrum(data); // Get power spectrum of signal waveform. 
                    // Call the following function to calculate current powerPeak and frequencyPeak.
                    currentPeakData();
                    // continue to acquire if task still running
                    reader.BeginReadMultiSample(samplesPerChannel, new AsyncCallback(myCallback), myTask);
                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
                runningTask = null;
                myTask.Dispose();
            }
        }

        private void acquisitionChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            try
            {   // Acquisition ON
                if (acquisitionStateSwitch.Value && runningTask == null)
                {
                    samplingRate = rateNumericEdit.Value;
                    samplesPerChannel = Convert.ToInt16(samplesNumericEdit.Value);

                    myTask = new Task("aiTask");

                    myTask.AIChannels.CreateVoltageChannel(channelTextBox.Text, "aiChannel", AITerminalConfiguration.Differential, -10.0,
                        10.0, AIVoltageUnits.Volts);

                    myTask.Timing.ConfigureSampleClock("", samplingRate, SampleClockActiveEdge.Rising,
                        SampleQuantityMode.ContinuousSamples, samplesPerChannel);
                    runningTask = myTask;
                    reader = new AnalogSingleChannelReader(myTask.Stream);
                    reader.SynchronizeCallbacks = true;
                    reader.BeginReadMultiSample(samplesPerChannel, new AsyncCallback(myCallback), myTask);

                    rateNumericEdit.Enabled = false;
                    samplesNumericEdit.Enabled = false;
                    channelTextBox.Enabled = false;
                }

                else // Acquisition OFF
                {
                    if (runningTask != null)
                    {
                        runningTask = null;
                        myTask.Dispose();
                    }
                    rateNumericEdit.Enabled = true;
                    samplesNumericEdit.Enabled = true;
                    channelTextBox.Enabled = true;
                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
                runningTask = null;
                myTask.Dispose();
            }

        }


        void getUnitConvertedAutoPowerSpectrum(double[] waveform)
        {
            double[] unitConvertedSpectrum;
            double[] subsetOfUnitConvertedSpectrum = new double[samplesPerChannel / 2];
            System.Text.StringBuilder unit;
            int i;

            ScalingMode scalingMode = ScalingMode.Linear;
            DisplayUnits displayUnit = DisplayUnits.VoltsRms;
            ScaledWindow scaledWindow;

            //  Set Window Type specified by the user.
            switch (windowComboBox.SelectedIndex)
            {
                case 0:
                    scaledWindow = ScaledWindow.CreateRectangularWindow();
                    break;
                case 1:
                    scaledWindow = ScaledWindow.CreateHanningWindow();
                    break;
                case 2:
                    scaledWindow = ScaledWindow.CreateHammingWindow();
                    break;
                case 3:
                    scaledWindow = ScaledWindow.CreateBlackmanHarrisWindow();
                    break;
                case 4:
                    scaledWindow = ScaledWindow.CreateExactBlackmanWindow();
                    break;
                case 5:
                    scaledWindow = ScaledWindow.CreateBlackmanWindow();
                    break;
                case 6:
                default:
                    scaledWindow = ScaledWindow.CreateFlatTopWindow();
                    break;
                case 7:
                    scaledWindow = ScaledWindow.CreateBlackmanHarris4TermWindow();
                    break;
                case 8:
                    scaledWindow = ScaledWindow.CreateBlackmanHarris7TermWindow();
                    break;
            }

            // Units selected by the user in which auto power spectrum has to be displayed.
            switch (unitsComboBox.SelectedIndex)
            {
                case 0:
                default:
                    displayUnit = DisplayUnits.VoltsRms;
                    break;
                case 1:
                    displayUnit = DisplayUnits.VoltsRmsSquared;
                    break;
                case 2:
                    displayUnit = DisplayUnits.VoltsRmsPerRootHZ;
                    break;
                case 3:
                    displayUnit = DisplayUnits.VoltsPeakSquaredPerHZ;
                    break;
                case 4:
                    displayUnit = DisplayUnits.VoltsPeak;
                    break;
                case 5:
                    displayUnit = DisplayUnits.VoltsPeakSquared;
                    break;
                case 6:
                    displayUnit = DisplayUnits.VoltsPeakPerRootHZ;
                    break;
                case 7:
                    displayUnit = DisplayUnits.VoltsRmsSquaredPerHZ;
                    break;
            }

            // Scale Selection: Linear, dB or dBm
            switch (scaleComboBox.SelectedIndex)
            {
                case 0:
                    scalingMode = ScalingMode.Linear;
                    break;
                case 1:
                    scalingMode = ScalingMode.DB;
                    break;
                case 2:
                    scalingMode = ScalingMode.DBM;
                    break;
            }

            scaledWindow.Apply(waveform, out equivalentNoiseBandwidth, out coherentGain);

            // Calculate the auto power spectrum of signal waveform.
            autoPowerSpectrum = new double[samplesPerChannel];
            autoPowerSpectrum = Measurements.AutoPowerSpectrum(waveform, 1.0 / samplingRate, out df);

            // Unit conversion of auto power spectrum as specified by the user.
            unit = new System.Text.StringBuilder("V", 256);
            unitConvertedSpectrum = new double[samplesPerChannel];
            unitConvertedSpectrum = Measurements.SpectrumUnitConversion(autoPowerSpectrum,
                SpectrumType.Power, scalingMode, displayUnit, df,
                equivalentNoiseBandwidth, coherentGain, unit);

            //Set the caption of yAxis according to the chosen unit of display.
            powerSpectrumYAxis.Caption = unit.ToString();

            for (i = 0; i < (samplesPerChannel / 2); i++)
            {
                subsetOfUnitConvertedSpectrum[i] = unitConvertedSpectrum[i];
            }

            // Plot unitConvertedSpectrum.
            powerSpectrumWaveformGraph.PlotY(subsetOfUnitConvertedSpectrum, 0, df);
        }


        void currentPeakData()
        {
            double frequencyPeak;
            double powerPeak;

            // Get the current XPosition of cursor
            searchFrequency = xyCursor.XPosition;

            // Apply PowerFrequencyEstimate function 
            Measurements.PowerFrequencyEstimate(autoPowerSpectrum, searchFrequency,
                equivalentNoiseBandwidth, coherentGain, df, 7, out frequencyPeak, out powerPeak);

            // Update Frequency Peak and Power Frequency 
            peakFrequencyNumericEdit.Value = frequencyPeak;
            peakPowerNumericEdit.Value = powerPeak;
        }
    }
}
