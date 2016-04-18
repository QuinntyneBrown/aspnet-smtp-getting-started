using Chloe.Server.Models;

namespace Chloe.Server.Dtos
{
    public class NewsletterTemplateDto
    {
        public NewsletterTemplateDto(NewsletterTemplate entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
        }

        public NewsletterTemplateDto()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
