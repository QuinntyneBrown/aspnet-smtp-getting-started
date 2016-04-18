using Chloe.Server.Services.Contracts;

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

        protected readonly IMessageSender messageSender;
        protected readonly IMessageBuilder messageBuilder;
        protected readonly IDistributionListService distributionListService;
    }
}