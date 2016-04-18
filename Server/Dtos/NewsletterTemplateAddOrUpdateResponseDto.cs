using Chloe.Server.Models;

namespace Chloe.Server.Dtos
{
    public class NewsletterTemplateAddOrUpdateResponseDto: NewsletterTemplateDto
    {
        public NewsletterTemplateAddOrUpdateResponseDto(NewsletterTemplate entity)
            :base(entity)
        {

        }
    }
}
