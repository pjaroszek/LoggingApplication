using Serilog;

namespace Jaroszek.ProofOfConcept.SeriLogEngine
{
    public static class SetConfigurationLogger
    {
        public static ILogger GetLogger()
        {
            var loggerConfig = new LoggerConfiguration()
                .WriteTo.Console()
                //  .WriteTo.File("log.log")
                .WriteTo.Seq("http://localhost:5341");

            return loggerConfig.CreateLogger();
        }
    }
}