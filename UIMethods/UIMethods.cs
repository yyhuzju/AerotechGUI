using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
using Logging;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace UIMethods
{
    public static class UIModificationStatic
    {

        internal static void ShowLoggerForm(Form form, SysLogger sysLogger)
        {
            LoggerForm loggerForm;
            bool loggerFormOpened = false;
            foreach (var frm in Application.OpenForms)
            {
                if (frm is LoggerForm)
                {
                    loggerForm = (LoggerForm)frm;
                    if (loggerForm.LoggerType == sysLogger.loggerType)
                    {
                        loggerFormOpened = true;
                        loggerForm.Focus();
                        break;
                    }
                }
            }
            if (!loggerFormOpened)
            {
                loggerForm = new LoggerForm(sysLogger);
                loggerForm.Show();
            }
        }
        private static void DisplayStatus(ToolStripStatusLabel labelStatus, string eS)
        {
            labelStatus.Text = eS;
        }
        private static void DisplayMessage(ToolStripStatusLabel labelMessage, string eM)
        {
            labelMessage.Text = eM;
        }
        internal static void Logging(ToolStripStatusLabel labelStatus, ToolStripStatusLabel labelMessage, SysLogger sysLogger, string eS, string eM)
        {

            switch (eS)
            {
                case "Error":
                    sysLogger.Error(eM);
                    labelStatus.BackColor = Color.Red;
                    break;
                case "FatalError":
                    sysLogger.Fatal(eM);
                    labelStatus.BackColor = Color.DarkRed;
                    break;
                case "Warning":
                    sysLogger.Warn(eM);
                  labelStatus.BackColor = Color.Yellow;
                    break;
                default:
                    sysLogger.Info(eM);
                    labelStatus.BackColor = Color.Green;
                    break;
            }
            DisplayStatus(labelStatus, eS);
            DisplayMessage(labelMessage, eM);
        }
        internal static string AxisCollectionLog(string[] axisName)
        {
            string axisNameCollection = null;
            switch (axisName.Length.ToString())
            {
                case "0":
                    axisNameCollection = "No ";
                    break;
                case "1":
                    axisNameCollection = axisName[0];
                    break;
                case "2":
                    axisNameCollection = axisName[1] + " and " + axisName[0];
                    break;
                default:
                    for (int i = axisName.Length - 1; i > 0; i--)
                    {
                        axisNameCollection = axisNameCollection + axisName[i] + ", ";
                    }
                    axisNameCollection = axisNameCollection + "and " + axisName[0];
                    break;
            }
            return axisNameCollection;
        }
        public static void InitializeDataListView(DataGridView dataGridView, int axisNum)
        {
            DataGridViewTextBoxColumn Position = new DataGridViewTextBoxColumn();
            Position.HeaderText = "Pos FB";
            Position.Width = 100;
            DataGridViewTextBoxColumn velocity = new DataGridViewTextBoxColumn();
            velocity.HeaderText = "Vel FB";
            velocity.Width = 100;

            dataGridView.Columns.AddRange(new DataGridViewColumn[] { velocity, Position });
            for (int i = 0; i < axisNum; i++)
                dataGridView.Rows.Add(new string[] { "No Data", "No Data" });
            
        }
        public static void SetDataListView(DataGridView dataGridView, int row, string pos, string vel )
        {
            dataGridView.Rows[row].SetValues(new string[] { pos, vel});
        }
        public static void SetLEDArray(LedArray leds, int axisNum)
        {
            leds.ScaleMode = ControlArrayScaleMode.CreateFixedMode(axisNum);
        }
        public static void SetSwitchArray(SwitchArray switches, int axisNum)
        {
            switches.ScaleMode = ControlArrayScaleMode.CreateFixedMode(axisNum);
        }
    }
    public class UIModification
    {
    }
}
