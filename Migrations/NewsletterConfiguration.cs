namespace Chloe.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class NewsletterConfiguration : DbMigrationsConfiguration<Chloe.Server.Data.NewsletterContext>
    {
        public NewsletterConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Chloe.Server.Data.NewsletterContext context)
        {

        }
    }
}
