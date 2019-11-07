using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;

namespace Jaroszek.ProofOfConcept.Library.Enterprise
{
    public class LoggingEnterprise
    {
        private readonly LoggingConfiguration loggingConfiguration = EnterpriseConfiguration.BuildProgrammaticConfig();//new EnterpriseConfiguration();

        public void LogIn(System.Diagnostics.TraceEventType traceEventType, string logMessage)
        {

            var defaultWriter = new LogWriter(loggingConfiguration);

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
