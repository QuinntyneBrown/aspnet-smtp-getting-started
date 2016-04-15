using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Chloe.Server.Services.Contracts
{
    public interface IMessageBuilder
    {
        MailMessage BuildTest();
    }
}