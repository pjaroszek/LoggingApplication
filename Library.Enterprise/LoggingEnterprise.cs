using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;

namespace Jaroszek.ProofOfConcept.Library.Enterprise
{
    public class LoggingEnterprise
    {
        private readonly LoggingConfiguration loggingConfiguration = EnterpriseConfiguration.BuildProgrammaticConfig();//new EnterpriseConfiguration();
        private readonly LoggingConfiguration loggingConfigurationAsync = EnterpriseConfiguration.BuildProgrammaticConfig(true);//new EnterpriseConfiguration();
        private readonly LogWriterFactory logWriterFactory = new LogWriterFactory();

        public void LogIn(System.Diagnostics.TraceEventType traceEventType, string logMessage, int priority = 0, int eventId = 0, bool isAsync = false)
        {
            LogWriter defaultWriter;
            //            if (isAsync)
            //            {
            //                defaultWriter = new LogWriter(loggingConfigurationAsync);
            //            }
            //            else
            //            {
            //                defaultWriter = new LogWriter(loggingConfiguration);
            //            }

            // dla konfiguracji pobieranej z App.config
            defaultWriter = logWriterFactory.Create();

            if (!defaultWriter.IsLoggingEnabled())
            {
                return;
            }
            defaultWriter.Write(new LogEntry()
            {
                Severity = traceEventType,
                TimeStamp = DateTime.Now,
                Message = logMessage,
                Priority = priority,
                EventId = eventId
            });



        }
    }
}
