using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Jaroszek.ProofOfConcept.Library.Enterprise.Test
{
    [TestClass]
    public class LoggerBlockTest
    {
        //Example to https://www.c-sharpcorner.com/article/logging-block-in-microsoft-enterprise-library-6-0/
        LoggerBlock loggerBlock = new LoggerBlock();

        [TestMethod]
        public void LoggerBlock()
        {
            WriteTraceLog("Application Stopped!!!");

        }

        private void WriteTraceLog(String message)
        {
            loggerBlock.LogWriter.Write(message, "General", 5, 2000, TraceEventType.Information);
        }
    }
}