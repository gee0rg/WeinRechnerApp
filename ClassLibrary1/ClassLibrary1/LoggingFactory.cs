using System;
using System.Collections.Generic;
using System.Text;

namespace WeinrechnerCommon
{
    public static class LoggingFactory
    {
        public static ILogger GetLogger(Type type)
        {
            return new Log4NetAdapter(type);
        }
    }
}
