﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Services
{
    public interface IMessageLogger
    {
        void Log(string message);
    }
}
