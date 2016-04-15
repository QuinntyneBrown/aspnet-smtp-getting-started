using Chloe.Server.Data.Contracts;
using Chloe.Server.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chloe.Server.Services
{
    public class MessageService: IMessageService
    {
        public MessageService(IChloeUow uow)
        {
            this.uow = uow;
        }
        public IChloeUow uow { get; set; }
    }
}