using Jaroszek.ProofOfConcept.SeriLogEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serilog;

namespace Jaroszek.ProofOfConcept.SeriLogLogging.Test
{
    [TestClass]
    public class SeriLogTest
    {
        SeriLogEngine.SeriLogLogging seriLogLoggingEngine = new SeriLogEngine.SeriLogLogging();

        [TestMethod]
        public void CreateNewLog()
        {
            // seriLogLoggingEngine.LogIn();
            Log.Logger = SetConfigurationLogger.GetLogger();

            Log.Logger.Information("error test");
            Log.CloseAndFlush();

        }
    }
}
