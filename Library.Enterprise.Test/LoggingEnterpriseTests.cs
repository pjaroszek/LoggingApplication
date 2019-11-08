using Jaroszek.ProofOfConcept.Library.Enterprise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.Enterprise.Test
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
            loggingEnterprise.LogIn(System.Diagnostics.TraceEventType.Information, "Test logu");

        }


        [TestMethod]
        public void LooggingEnterpriseTestAsyncWriteLof()
        {
            Execute();
            loggingEnterprise.LogIn(System.Diagnostics.TraceEventType.Information, "Test logu Async", true);
        }
    }
}
