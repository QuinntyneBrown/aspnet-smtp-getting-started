using Chloe.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Server.Data.Contracts
{
    public interface ILogUow
    {
        IRepository<LogEntry> LogEntries { get; }
        void SaveChanges();
    }
}
