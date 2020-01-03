using System;

namespace Extensibiity
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            this._logger = logger; // Dependency injection
        }

        public void Mirgrate()
        {
            _logger.LogInfo($"Migration started at {DateTime.Now}");
            // Details of migrating the database
            _logger.LogInfo($"Migration finished at {DateTime.Now}");
        }
    }
}
