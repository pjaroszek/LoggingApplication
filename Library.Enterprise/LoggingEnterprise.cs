using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;

namespace Jaroszek.ProofOfConcept.Library.Enterprise
{
    public class LoggingEnterprise
    {
        private readonly LoggingConfiguration loggingConfiguration = EnterpriseConfiguration.BuildProgrammaticConfig();//new EnterpriseConfiguration();
        private readonly LogWriterFactory logWriterFactory = new LogWriterFactory();

        public void LogIn(System.Diagnostics.TraceEventType traceEventType, string logMessage)
        {

            var defaultWriter = new LogWriter(loggingConfiguration);
            // dla konfiguracji pobieranej z App.config
            var defaultWriterAppConfig = logWriterFactory.Create();

            if (!defaultWriter.IsLoggingEnabled())
            {
                return;
            }
            defaultWriter.Write(new LogEntry()
            {
                Severity = traceEventType,
                TimeStamp = DateTime.Now,
                Message = logMessage
            });

        }
    }
}
