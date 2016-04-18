using Chloe.Server.Models;

namespace Chloe.Server.Data.Contracts
{
    public interface INewsletterUow
    {
        IRepository<Recipient> Recipients { get; }
        IRepository<Notification> Notifications { get; }
        IRepository<Message> Messages { get; }
        IRepository<NewsletterTemplate> NewsletterTemplates { get; }
        void SaveChanges();
    }
}
