using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Server.Services.Contracts
{
    public interface IMessageSender
    {
        void Send(MailMessage mailMessage);
    }
}
