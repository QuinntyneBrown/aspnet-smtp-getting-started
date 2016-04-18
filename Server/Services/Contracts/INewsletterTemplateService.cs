using Chloe.Server.Dtos;
using System.Collections.Generic;

namespace Chloe.Server.Services.Contracts
{
    public interface INewsletterTemplateService
    {
        NewsletterTemplateAddOrUpdateResponseDto AddOrUpdate(NewsletterTemplateAddOrUpdateRequestDto request);
        ICollection<NewsletterTemplateDto> Get();
        NewsletterTemplateDto GetById(int id);
        dynamic Remove(int id);
    }
}
