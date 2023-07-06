using System;

namespace OOP3
{
    internal class FileLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya  loglandı");
        }
    }
}

