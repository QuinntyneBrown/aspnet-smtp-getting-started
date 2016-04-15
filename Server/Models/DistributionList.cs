using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chloe.Server.Models
{
    public class DistributionList: BaseEntity
    {
        public DistributionList()
        {
            this.Recipients = new HashSet<Recipient>();
        }

        public ICollection<Recipient> Recipients { get; set; }
    }
}