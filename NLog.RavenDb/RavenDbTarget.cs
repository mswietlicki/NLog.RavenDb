using NLog.TypedLogs;
using Raven.Client.Document;

namespace NLog.Targets
{
    [Target("RavenDb")]
    public class RavenDbTarget : TargetWithLayout
    {

        public RavenDbTarget()
        {
            
        }

        //[Required] 
        public string Host { get; set; }
        public string Database { get; set; }
        public string ApiKey { get; set; }

        protected DocumentStore store { get; set; }

        protected override void InitializeTarget()
        {
            base.InitializeTarget();

            store = new DocumentStore { Url = Host, DefaultDatabase = Database };
            if (!string.IsNullOrEmpty(ApiKey))
            {
                store.ApiKey = ApiKey;
            }

            store.Initialize();
        }

        protected override void Write(LogEventInfo logEvent)
        {
             SendLogToRaven(logEvent);
        }

        protected override void Write(Common.AsyncLogEventInfo logEvent)
        {
            base.Write(logEvent);
        }

        protected override void FlushAsync(Common.AsyncContinuation asyncContinuation)
        {
            base.FlushAsync(asyncContinuation);
        }

        private void SendLogToRaven(LogEventInfo logEvent)
        {
            var factory = new TypedLogEventInfoFactory();

            if (logEvent.LoggerName.StartsWith("Raven.")) return;
            using (var session = store.OpenSession())
            {
                session.Store(factory.CreateTypedLogEventInfo(logEvent));
                session.SaveChanges();
            }
        }

        protected override void CloseTarget()
        {
            store.Dispose();
            base.CloseTarget();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected class Log
        {
            public int Id { get; set; }
            public string Message { get; set; }
        }

    }
}
