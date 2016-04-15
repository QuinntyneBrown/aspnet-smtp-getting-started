using Chloe.Server.Config.Contracts;
using Chloe.Server.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Chloe.Server.Services
{
    public class NotificationService: INotificationService
    {
        public NotificationService(IMessageSender messageSender, IMessageBuilder messageBuilder)
        {
            this.messageSender = messageSender;
            this.messageBuilder = messageBuilder;
        }

        public void SendTest() {
            var testMessage = this.messageBuilder.BuildTest();
            testMessage.To.Add("quinntynebrown@gmail.com");
            testMessage.From = new MailAddress("quinntynebrown@gmail.com");
            this.messageSender.Send(testMessage);
        }
        public ISmtpConfiguration smtpConfiguration { get; set; }

        public IMessageSender messageSender { get; set; }
        public IMessageBuilder messageBuilder { get; set; }
    }
}