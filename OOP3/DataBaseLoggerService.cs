﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class DataBaseLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}

