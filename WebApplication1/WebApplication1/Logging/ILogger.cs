using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Logging
{

    public interface ILogger
    {
        void Debug(object message);
        bool IsDebugEnabled { get; }

        void Info(object message);
        bool IsInfoEnabled { get; }


        void Warn(object message);
        bool IsWarnEnabled { get; }


        void Error(object message);
        void Error(object message, Exception ex);
        bool IsErrorEnabled { get; }


        void Fatal(object message);
        void Fatal(object message, Exception ex);
        bool IsFatalEnabled { get; }


    }
}
