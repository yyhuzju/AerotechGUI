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
        private Logger _logger;
        
        public Logger logger {
            get { return _logger; }
            set { _logger = value; }
        }
        private string _logFileName;
        public string logFileName
        {
            get { return _logFileName; }
            set { logFileName = value; }
        }
        private string _loggerType;
        public string loggerType {
            get { return _loggerType; }
            set { _loggerType = value; } 
        }
        public SysLogger(string definedLoggerTyoe,string logFileName) {
        
            _loggerType = definedLoggerTyoe;
            _logger = LogManager.GetLogger(_loggerType);
            logger = _logger;
            _logFileName = logFileName;
            LogManager.Configuration.Variables["logFileName"] = _logFileName;
            
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
