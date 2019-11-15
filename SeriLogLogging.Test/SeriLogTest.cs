using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jaroszek.ProofOfConcept.SeriLogLogging.Test
{
    [TestClass]
    public class SeriLogTest
    {
        SeriLogEngine.SeriLogLogging seriLogLoggingEngine = new SeriLogEngine.SeriLogLogging();

        [TestMethod]
        public void CreateNewLog()
        {
            seriLogLoggingEngine.LogIn();

        }
    }
}
