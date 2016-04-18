using Chloe.Server.Data.Contracts;
using Chloe.Server.Models;
using System.Data.Entity;

namespace Chloe.Server.Data
{
    public class NewsletterContext : DbContext, INewsletterContext
    {
        public NewsletterContext()
            : base(nameOrConnectionString: "NewsletterContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<LinkedResource> LinkedResources { get; set; }
        public DbSet<DistributionList> DistributionLists { get; set; }

        public DbSet<NewsletterTemplate> NewsletterTemplates { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}