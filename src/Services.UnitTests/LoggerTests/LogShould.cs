using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Moq;
using Xunit;
using Services;

namespace Services.UnitTests.LoggerTests
{
    public class LogShould
    {
        [Fact]
        public void Call_Log_with_message()
        {
            Mock<ConsoleLogger> mokConsoleLogger = new Mock<ConsoleLogger>();

            ConsoleLogger oConsoleLogger = mokConsoleLogger.Object;

            oConsoleLogger.Log("helloWorld");
            mokConsoleLogger.Verify(t => t.Log("helloWorld"));

            Mock<QueueLogger> mokQueueLogger = new Mock<QueueLogger>();

            QueueLogger oQueueLogger = mokQueueLogger.Object;

            oQueueLogger.Log("helloWorld");
            mokQueueLogger.Verify(t => t.Log("helloWorld"));
            //throw new NotImplementedException();            
        }
    }
}
