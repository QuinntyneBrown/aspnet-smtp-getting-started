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
        public NotificationService(IDistributionListService distributionListService, IMessageSender messageSender, IMessageBuilder messageBuilder)
        {
            this.messageSender = messageSender;
            this.messageBuilder = messageBuilder;
            this.distributionListService = distributionListService;
        }

        public void SendTestNotification() {
            var testMessage = this.messageBuilder.BuildTestMessage();
            testMessage = this.distributionListService.ResolveRecipients(testMessage);
            this.messageSender.Send(testMessage);
        }
        public ISmtpConfiguration smtpConfiguration { get; set; }

        public IMessageSender messageSender { get; set; }
        public IMessageBuilder messageBuilder { get; set; }

        protected readonly IDistributionListService distributionListService;
    }
}