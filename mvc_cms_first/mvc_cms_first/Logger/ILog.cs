using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_cms_first.Log
{
    public interface ILog
    {

        string Info(string infoText);
        void Warn(string warnText);
        void Debug(string debugText);
        void Error(string errorText);

    }

    public class DatabaseLogger : ILog
    {
        public string Info(string infoText)
        {
            return ($"[{DateTime.Now}][DatabaseLoggerInfo]:{infoText}");
        }

        public void Debug(string debugText)
        {
            Console.WriteLine($"[{DateTime.Now}][Debug]:{debugText}");

        }

        public void Error(string errorText)
        {

        }

        public void Warn(string warnText)
        {

        }
    }

    public class ConsoleLogger : ILog
    {
        public string Info(string infoText)
        {
            return ($"[{DateTime.Now}][ConsoleLoggerInfo]:{infoText}");
        }

        public void Debug(string debugText)
        {
            Console.WriteLine($"[{DateTime.Now}][Debug]:{debugText}");

        }

        public void Error(string errorText)
        {

        }

        public void Warn(string warnText)
        {

        }
    }

    public class AzureStorageLogger : ILog
    {
        public string Info(string infoText)
        {
            return ($"[{DateTime.Now}][Info]:{infoText}");
        }

        public void Debug(string debugText)
        {
            Console.WriteLine($"[{DateTime.Now}][Debug]:{debugText}");

        }

        public void Error(string errorText)
        {

        }

        public void Warn(string warnText)
        {

        }
    }

}
