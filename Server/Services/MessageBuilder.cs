using Chloe.Server.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Web;

namespace Chloe.Server.Services
{
    public class MessageBuilder: IMessageBuilder
    {
        public MailMessage BuildTest()
        {
            var mailMessage = new MailMessage();
            var html = @"<html><body><h1>Test</h1></body></html>";
            mailMessage.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html));
            return mailMessage;
        }
    }
}