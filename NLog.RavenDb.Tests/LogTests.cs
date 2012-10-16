using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NLog.RavenDb.Tests
{
    [TestClass]
    public class LogTests
    {
        [TestMethod]
        public void LogInfo()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            logger.Info("TestInfo");

            logger.Factory.Dispose();
        }

        [TestMethod]
        public void LogException()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            logger.ErrorException("This is Test Exception", new StackOverflowException("New StackOverflow Exception!"));

            logger.Factory.Dispose();
        }
    }
}
