using System;

namespace Core.CCS
{
    public class FileLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }

    public class DatabaseLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}