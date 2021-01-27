using System;

namespace OOP3
{
    class FileBaseLoggerService : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
