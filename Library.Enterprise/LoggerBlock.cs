using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace Jaroszek.ProofOfConcept.Library.Enterprise
{
    public class LoggerBlock
    {
        protected LogWriter logWriter;

        public LoggerBlock()
        {
            InitLogging();
        }

        private void InitLogging()
        {
            logWriter = new LogWriterFactory().Create();
            Logger.SetLogWriter(logWriter, false);
        }

        public LogWriter LogWriter
        {
            get
            {
                return logWriter;
            }
        }
    }
}