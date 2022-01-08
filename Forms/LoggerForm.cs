using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using Logging;

namespace GUI
{
    public partial class LoggerForm : Form
    {
        private string _logFilePath;
        private string _logFileName;
        private string _loggerType;
        public string LoggerType { get { return _loggerType; } }


        public LoggerForm(SysLogger sysLogger)
        {
            InitializeComponent();
            _logFilePath = sysLogger.logFilePath;
            _logFileName = sysLogger.logFileName;
            _loggerType = sysLogger.loggerType;
            logWatcher.Changed += WriteFile;
            logWatcher.Created += WriteFile;
            logWatcher.Deleted += (o, e) => txtFileContents.Text = "";
        }
        private void WriteFile(object o, FileSystemEventArgs e)
        {
            txtFileContents.Text = File.ReadAllText(Path.Combine(_logFilePath, _logFileName));
            txtFileContents.SelectionStart = txtFileContents.Text.Length;
            txtFileContents.ScrollToCaret();
        }
        private void LoggerForm_Load(object sender, EventArgs e)
        {
            logWatcher.Path = _logFilePath;
            logWatcher.EnableRaisingEvents = true;
            txtFileContents.Text = File.ReadAllText(Path.Combine(_logFilePath, _logFileName));
        }
    }
}
