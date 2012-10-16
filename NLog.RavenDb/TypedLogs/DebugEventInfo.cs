using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLog.TypedLogs
{
    public class DebugEventInfo : LogEventInfo
    {
        public DebugEventInfo() : base() { }
        public DebugEventInfo(LogLevel level, string loggerName, string message)
            : base(level, loggerName, message) { }
        public DebugEventInfo(LogLevel level, string loggerName, IFormatProvider formatProvider, string message, object[] parameters)
            : base(level, loggerName, formatProvider, message, parameters) { }
        public DebugEventInfo(LogLevel level, string loggerName, IFormatProvider formatProvider, string message, object[] parameters, Exception exception)
            : base(level, loggerName, formatProvider, message, parameters, exception) { }

        public static DebugEventInfo CreateFromLogEventInfo(LogEventInfo logEvent)
        {
            return new DebugEventInfo(logEvent.Level, logEvent.LoggerName, logEvent.FormatProvider, logEvent.Message, logEvent.Parameters, logEvent.Exception);
        }
    }
}
