using System;
using System.IO;
using System.Text;

namespace Extensibiity
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogErr(string message);
    }

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

    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }

        public void LogErr(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true, Encoding.UTF8))
            {
                streamWriter.WriteLine($"{messageType}: {message}.");
            }
        }
    }

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            this._logger = logger; // Dependency injection
        }

        public void Mirgrate()
        {
            _logger.LogInfo($"Migration started at {DateTime.Now}.");
            // Details of migrating the database
            _logger.LogInfo($"Migration finished at {DateTime.Now}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Mirgrate();
        }
    }
}
