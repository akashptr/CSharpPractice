using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Intermediate.Extensibility
{
    public class DbMigrator
    {
        private ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at: " + DateTime.Now);
            _logger.LogInfo("Migration ended at: " + DateTime.Now);
        }
    }
}
