using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;

namespace Library.Enterprise
{
    public class LoggingEnterprise
    {
        private readonly IConfigurationSource configurationSource = ConfigurationSourceFactory.Create();

        public void LogIn(System.Diagnostics.TraceEventType traceEventType, string logMessage)
        {
            LogWriterFactory logWriterFactory = new LogWriterFactory(configurationSource);
            Logger.SetLogWriter(logWriterFactory.Create());
            if (!Logger.IsLoggingEnabled())
            {
                return;
            }
            Logger.Writer.Write(new LogEntry()
            {
                Severity = traceEventType,
                TimeStamp = DateTime.Now,
                Message = traceEventType + " " + logMessage
            });

        }
    }
}
