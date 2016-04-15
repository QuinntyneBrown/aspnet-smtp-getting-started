using Chloe.Server.Models;

namespace Chloe.Server.Data.Contracts
{
    public interface IChloeUow
    {
        IRepository<Recipient> Recipients { get; }
        IRepository<Notification> Notifications { get; }
        IRepository<Message> Messages { get; }
        void SaveChanges();
    }
}
