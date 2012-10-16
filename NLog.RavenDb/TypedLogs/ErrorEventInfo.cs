using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLog.TypedLogs
{
    public class ErrorEventInfo : LogEventInfo
    {
        public ErrorEventInfo() : base() { }
        public ErrorEventInfo(LogLevel level, string loggerName, string message)
            : base(level, loggerName, message) { }
        public ErrorEventInfo(LogLevel level, string loggerName, IFormatProvider formatProvider, string message, object[] parameters)
            : base(level, loggerName, formatProvider, message, parameters) { }
        public ErrorEventInfo(LogLevel level, string loggerName, IFormatProvider formatProvider, string message, object[] parameters, Exception exception)
            : base(level, loggerName, formatProvider, message, parameters, exception) { }

        public static ErrorEventInfo CreateFromLogEventInfo(LogEventInfo logEvent)
        {
            return new ErrorEventInfo(logEvent.Level, logEvent.LoggerName, logEvent.FormatProvider, logEvent.Message, logEvent.Parameters, logEvent.Exception);
        }
    }
}
