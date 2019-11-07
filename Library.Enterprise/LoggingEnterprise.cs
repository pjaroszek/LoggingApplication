using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Diagnostics;

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
         //   var defaultWriterAppConfig = logWriterFactory.Create();

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
            defaultWriter.Write("Log entry created using the simplest overload.");
            defaultWriter.Write("Log entry with a single category.", "General");
            defaultWriter.Write("Log entry with a category, priority, and event ID.",
                "General", 6, 9001);
            defaultWriter.Write("Log entry with a category, priority, event ID, "
                                + "and severity.", "General", 5, 9002,
                TraceEventType.Warning);
            defaultWriter.Write("Log entry with a category, priority, event ID, "
                                + "severity, and title.", "General", 8, 9003,
                TraceEventType.Warning, "Logging Block Examples");

        }
    }
}
