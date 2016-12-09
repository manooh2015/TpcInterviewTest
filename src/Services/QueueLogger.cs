using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class QueueLogger : IMessageLogger
    {
        public virtual void Log(string message)
        {
            //code to send message to printer
        }
    }
}
