using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace WeinrechnerCommon
{
   public class Log4NetAdapter : ILogger
    {
        private readonly log4net.ILog _log;

        public Log4NetAdapter(Type type)
        {

            //XmlConfigurator.Configure();
            //_log = LogManager.GetLogger(ApplicationSettingsFactory.GetApplicationSettings().LoggerName);
            _log = LogManager.GetLogger(type);
            if (!LogManager.GetRepository().Configured)
            {
                System.Diagnostics.Trace.WriteLine("Error: Log4Net not Configured!");
                foreach (log4net.Util.LogLog message in log4net.LogManager.GetRepository().ConfigurationMessages.Cast<log4net.Util.LogLog>())
                {
                    System.Diagnostics.Trace.WriteLine(message);
                }
            }
        }

        public void Debug(object message)
        {
            _log.Debug(message);
        }

        public bool IsDebugEnabled
        {
            get { return _log.IsDebugEnabled; }
        }

        public void Info(object message)
        {
            _log.Info(message);
        }

        public bool IsInfoEnabled
        {
            get { return _log.IsInfoEnabled; }
        }

        public void Warn(object message)
        {
            _log.Warn(message);
        }

        public bool IsWarnEnabled
        {
            get { return _log.IsWarnEnabled; }
        }

        public void Error(object message)
        {
            _log.Error(message);
        }

        public void Error(object message, Exception ex)
        {
            _log.Error(message, ex);
        }



        public bool IsErrorEnabled
        {
            get { return _log.IsErrorEnabled; }
        }

        public void Fatal(object message)
        {
            _log.Fatal(message);
        }
        public void Fatal(object message, Exception ex)
        {
            _log.Fatal(message, ex);
        }


        public bool IsFatalEnabled
        {
            get { return _log.IsFatalEnabled; }
        }
    }
}
