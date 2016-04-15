using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chloe.Server.Models
{
    public class Message : BaseEntity
    {
        public Message()
        {
            this.LinkedResources = new HashSet<LinkedResource>();
        }
        public string HtmlBody { get; set; }

        public ICollection<LinkedResource> LinkedResources { get; set; }
    }
}