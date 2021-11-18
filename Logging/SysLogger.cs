using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using NLog;
using GUI;

namespace Logging
{
    public class SysLogger
    {
        private string _logFilePath = Path.Combine(Path.GetDirectoryName
            (Assembly.GetExecutingAssembly().Location), "logs");
        public string logFilePath{
            get { return _logFilePath; }
            set { _logFilePath = value; }
        }
        private Logger _logger = LogManager.GetLogger("app_logger");
        
        public Logger logger {
            get { return _logger; }
            set { _logger = value; }
        }
        public SysLogger(string loggerName) {
            _logger = LogManager.GetLogger(loggerName);
            logger = _logger;
        }
        public void Trace(string strMsg)
        {
            logger.Trace(strMsg);
        }

        public void Debug(string strMsg)
        {
            logger.Debug(strMsg);
        }

        public void Info(string strMsg)
        {
            logger.Info(strMsg);
        }

        public void Warn(string strMsg)
        {
            logger.Warn(strMsg);
        }

        public void Error(string strMsg)
        {
            logger.Error(strMsg);
        }

        public void Fatal(string strMsg)
        {
            logger.Fatal(strMsg);
        }
    }
}
