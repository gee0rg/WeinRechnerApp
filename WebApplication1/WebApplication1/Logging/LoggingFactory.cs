using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Logging
{
    public static class LoggingFactory
    {
        public static ILogger GetLogger(Type type)
        {
            return new Log4NetAdapter(type);
        }
    }
}