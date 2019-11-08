using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;
using System.Diagnostics;

namespace Jaroszek.ProofOfConcept.Library.Enterprise
{
    public class EnterpriseConfiguration
    {
        public static LoggingConfiguration BuildProgrammaticConfig(bool isAsync = false)
        {

            var formatter = new TextFormatter();

            var flatFileTraceListener = new FlatFileTraceListener(@"FlatFile.log",
                "----------------------------------------",
                "----------------------------------------",
                formatter);

            //   var eventLog = new EventLog("Application", ".", "LoggingApplication");
            //   var eventLogTraceListener = new FormattedEventLogTraceListener(eventLog, formatter);

            // Build Configuration
            var config = new LoggingConfiguration();

            if (isAsync == false)
            {
                config.AddLogSource("General", SourceLevels.All, true)
                    // .AddTraceListener(eventLogTraceListener);
                    .AddTraceListener(flatFileTraceListener);
            }
            else
            {
                config.AddLogSource("General", SourceLevels.All, true)
                     // .AddTraceListener(eventLogTraceListener);
                     .AddAsynchronousTraceListener(flatFileTraceListener);
            }


            config.IsTracingEnabled = true;
            return config;
        }
    }
}
