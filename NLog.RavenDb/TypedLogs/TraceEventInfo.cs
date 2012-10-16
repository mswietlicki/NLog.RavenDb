using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLog.TypedLogs
{
    public class TraceEventInfo : LogEventInfo
    {
        public TraceEventInfo() : base() { }
        public TraceEventInfo(LogLevel level, string loggerName, string message)
            : base(level, loggerName, message) { }
        public TraceEventInfo(LogLevel level, string loggerName, IFormatProvider formatProvider, string message, object[] parameters)
            : base(level, loggerName, formatProvider, message, parameters) { }
        public TraceEventInfo(LogLevel level, string loggerName, IFormatProvider formatProvider, string message, object[] parameters, Exception exception)
            : base(level, loggerName, formatProvider, message, parameters, exception) { }

        public static TraceEventInfo CreateFromLogEventInfo(LogEventInfo logEvent)
        {
            return new TraceEventInfo(logEvent.Level, logEvent.LoggerName, logEvent.FormatProvider, logEvent.Message, logEvent.Parameters, logEvent.Exception);
        }
    }
}
