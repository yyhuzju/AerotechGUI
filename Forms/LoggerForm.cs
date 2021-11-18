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

namespace GUI
{
    public partial class LoggerForm : Form
    {
        private string _logFilePath;

        public LoggerForm(Logger logger, string logFilePath)
        {
            InitializeComponent();
            _logFilePath = logFilePath;      
            logWatcher.Changed += WriteFile;
            logWatcher.Created += WriteFile;
            logWatcher.Deleted += (o, e) => txtFileContents.Text = "";

            logger = LogManager.GetLogger("app_logger");
        }
        private void WriteFile(object o, FileSystemEventArgs e)
        {
            txtFileContents.Text = File.ReadAllText(Path.Combine(_logFilePath, "AppLog.txt"));
            txtFileContents.SelectionStart = txtFileContents.Text.Length;
            txtFileContents.ScrollToCaret();
        }
        private void LoggerForm_Load(object sender, EventArgs e)
        {
            logWatcher.Path = _logFilePath;
            logWatcher.EnableRaisingEvents = true;
            txtFileContents.Text = File.ReadAllText(Path.Combine(_logFilePath, "AppLog.txt"));
        }
    }
}
