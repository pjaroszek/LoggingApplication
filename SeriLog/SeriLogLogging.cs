using Serilog;

namespace Jaroszek.ProofOfConcept.SeriLog
{
    using System;

    public class SeriLogLogging
    {
        public void LogIn()
        {
            Log.Logger = new LoggerConfiguration()
                //.WriteTo.Console()
                .WriteTo.Seq("http://localhost:5341")
                .CreateLogger();
            Log.Information("Witaj, {Name}", Environment.UserName);
            Log.CloseAndFlush();
        }
    }
}