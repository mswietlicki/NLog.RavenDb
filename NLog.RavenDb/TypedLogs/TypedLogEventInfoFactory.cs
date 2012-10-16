using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLog.TypedLogs
{
    public class TypedLogEventInfoFactory
    {
        public LogEventInfo CreateTypedLogEventInfo(LogEventInfo logEvent)
        {

            if (logEvent.Level == LogLevel.Trace)
                return TraceEventInfo.CreateFromLogEventInfo(logEvent);
            if (logEvent.Level == LogLevel.Debug)
                return DebugEventInfo.CreateFromLogEventInfo(logEvent);
            if (logEvent.Level == LogLevel.Info)
                return InfoEventInfo.CreateFromLogEventInfo(logEvent);
            if (logEvent.Level == LogLevel.Warn)
                return WarnEventInfo.CreateFromLogEventInfo(logEvent);
            if (logEvent.Level == LogLevel.Error)
                return ErrorEventInfo.CreateFromLogEventInfo(logEvent);
            if (logEvent.Level == LogLevel.Fatal)
                return FatalEventInfo.CreateFromLogEventInfo(logEvent);


            return logEvent;
        }
    }
}
