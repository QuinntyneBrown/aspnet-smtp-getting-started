using System;

namespace Chloe.Server.Exceptions
{
    public class NewsletterTemplateNotFoundException: NotFoundException
    {
        public NewsletterTemplateNotFoundException()
            :base("Newsletter Template Not Found")
        {
        }

        public NewsletterTemplateNotFoundException(string message)
            :base(message)
        {

        }

        public NewsletterTemplateNotFoundException(string message, Exception inner)
        {

        }
    }
}
