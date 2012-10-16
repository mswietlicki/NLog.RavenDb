using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLog.TypedLogs
{
    public class FatalEventInfo : LogEventInfo
    {
        public FatalEventInfo() : base() { }
        public FatalEventInfo(LogLevel level, string loggerName, string message)
            : base(level, loggerName, message) { }
        public FatalEventInfo(LogLevel level, string loggerName, IFormatProvider formatProvider, string message, object[] parameters)
            : base(level, loggerName, formatProvider, message, parameters) { }
        public FatalEventInfo(LogLevel level, string loggerName, IFormatProvider formatProvider, string message, object[] parameters, Exception exception)
            : base(level, loggerName, formatProvider, message, parameters, exception) { }

        public static FatalEventInfo CreateFromLogEventInfo(LogEventInfo logEvent)
        {
            return new FatalEventInfo(logEvent.Level, logEvent.LoggerName, logEvent.FormatProvider, logEvent.Message, logEvent.Parameters, logEvent.Exception);
        }
    }
}
