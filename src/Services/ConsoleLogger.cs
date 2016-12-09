using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class ConsoleLogger : IMessageLogger
    {
        public virtual void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
