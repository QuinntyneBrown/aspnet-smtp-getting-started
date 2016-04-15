using Chloe.Server.Data.Contracts;
using Chloe.Server.Models;
using System.Data.Entity;

namespace Chloe.Server.Data
{
    public class ChloeContext : DbContext, IDbContext
    {
        public ChloeContext()
            : base(nameOrConnectionString: "ChloeContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Recipient> Recipients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}