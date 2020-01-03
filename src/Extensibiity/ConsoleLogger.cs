using System;

namespace Extensibiity
{
    public class ConsoleLogger : ILogger
    {
        public void LogErr(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {message}");
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Info: {message}");
        }
    }
}
