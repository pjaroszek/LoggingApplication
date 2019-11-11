using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jaroszek.ProofOfConcept.Library.Enterprise.Test
{
    [TestClass]
    public class LoggingEnterpriseTests
    {
        private LoggingEnterprise loggingEnterprise;
        private void Execute()
        {
            loggingEnterprise = new LoggingEnterprise();
        }

        [TestMethod]
        public void LoggingEnterpriseTestsWriteLogToFile()
        {
            Execute();
            loggingEnterprise.LogIn(System.Diagnostics.TraceEventType.Information, "Test logu", 10, 4);

        }


        [TestMethod]
        public void LooggingEnterpriseTestAsyncWriteLof()
        {
            Execute();
            loggingEnterprise.LogIn(System.Diagnostics.TraceEventType.Information, "Test logu Async", 1, 1, true);
        }
    }
}
