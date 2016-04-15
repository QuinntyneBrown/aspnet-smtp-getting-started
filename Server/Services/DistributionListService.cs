using Chloe.Server.Data.Contracts;
using Chloe.Server.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Chloe.Server.Services
{
    public class DistributionListService : IDistributionListService
    {
        public DistributionListService(IChloeUow uow)
        {
            this.uow = uow;
        }

        public MailMessage ResolveRecipients(System.Net.Mail.MailMessage mailMessage)
        {
            mailMessage.To.Add("quinntynebrown@gmail.com");
            mailMessage.From = new MailAddress("quinntynebrown@gmail.com");
            return mailMessage;
        }

        protected readonly IChloeUow uow;
    }
}