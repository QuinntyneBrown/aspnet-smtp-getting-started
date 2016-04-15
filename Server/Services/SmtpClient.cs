using Chloe.Server.Config.Contracts;
using Chloe.Server.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Chloe.Server.Services
{
    public class SmtpClient: IMessageSender
    {
        public SmtpClient(Chloe.Server.Config.Contracts.IConfigurationProvider configurationProvider)
        {
            this.configuration = configurationProvider.Get<ISmtpConfiguration>();
            this.smtpClient = new System.Net.Mail.SmtpClient(this.configuration.Host, this.configuration.Port) {
                Credentials = new NetworkCredential(this.configuration.Username, this.configuration.Password),
                EnableSsl = true
            };
        }
        public void Send(System.Net.Mail.MailMessage mailMessage)
        {
            this.smtpClient.Send(mailMessage);
        }

        System.Net.Mail.SmtpClient smtpClient { get; set; }
        ISmtpConfiguration configuration { get; set; }
    }
}