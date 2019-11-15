
using Serilog;
using System;

namespace Jaroszek.ProofOfConcept.SeriLogEngine
{
    public class SeriLogLogging
    {
        public void LogIn()
        {
            //            Log.Logger = new LoggerConfiguration()
            //                .WriteTo.Console()
            //                .WriteTo.Seq("http://localhost:5341")
            //                .CreateLogger();


            Log.Logger = SetConfigurationLogger.GetLogger();

            Log.Information("Witaj, {Name}", Environment.UserName);

            Log.CloseAndFlush();
        }
    }
}
