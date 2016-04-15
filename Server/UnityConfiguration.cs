using Chloe.Server.Config;
using Chloe.Server.Config.Contracts;
using Chloe.Server.Data;
using Chloe.Server.Data.Contracts;
using Chloe.Server.Services;
using Chloe.Server.Services.Contracts;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chloe.Server
{
    public class UnityConfiguration
    {
        public static IUnityContainer GetContainer(bool useMock = false) 
        {

            var container = new UnityContainer()
                .AddNewExtension<Interception>();

            container.RegisterType<IChloeUow, ChloeUow>();
            container.RegisterType<IDbContext, ChloeContext>();
            container.RegisterType<IRepositoryProvider, RepositoryProvider>();
            container.RegisterType<IMessageService, MessageService>();
            container.RegisterType<IMessageBuilder, MessageBuilder>();
            container.RegisterType<ILinkedResourceService, LinkedResourceService>();
            container.RegisterType<IMessageSender, Chloe.Server.Services.SmtpClient>();
            container.RegisterType<INotificationService, NotificationService>();
            container.RegisterType<IConfigurationProvider, ConfigurationProvider>();
            container.RegisterType<IDistributionListService, DistributionListService>();

            return container;
        }

    }
}