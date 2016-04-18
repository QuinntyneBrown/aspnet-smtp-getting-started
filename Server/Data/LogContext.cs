using Chloe.Server.Data.Contracts;
using Chloe.Server.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Chloe.Server.Data
{
    public class LogContext : DbContext, ILogContext
    {
        public LogContext()
            : base(nameOrConnectionString: "LogContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<LogEntry> LogEntries { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}