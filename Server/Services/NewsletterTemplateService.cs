using System;
using System.Collections.Generic;
using Chloe.Server.Data.Contracts;
using Chloe.Server.Dtos;
using Chloe.Server.Services.Contracts;
using System.Data.Entity;
using System.Linq;
using Chloe.Server.Models;

namespace Chloe.Server.Services
{
    public class NewsletterTemplateService : INewsletterTemplateService
    {
        public NewsletterTemplateService(INewsletterUow uow, ICacheProvider cacheProvider)
        {
            this.uow = uow;
            this.repository = uow.NewsletterTemplates;
            this.cache = cacheProvider.GetCache();
        }

        public NewsletterTemplateAddOrUpdateResponseDto AddOrUpdate(NewsletterTemplateAddOrUpdateRequestDto request)
        {
            var entity = repository.GetAll()
                .Where(x => x.Id == request.Id && x.IsDeleted == false)
                .FirstOrDefault();
            if (entity == null) repository.Add(entity = new NewsletterTemplate());
            entity.Name = request.Name;
            uow.SaveChanges();
            return new NewsletterTemplateAddOrUpdateResponseDto(entity);
        }

        public dynamic Remove(int id)
        {
            var entity = repository.GetById(id);
            entity.IsDeleted = true;
            uow.SaveChanges();
            return id;
        }

        public ICollection<NewsletterTemplateDto> Get()
        {
            ICollection<NewsletterTemplateDto> response = new HashSet<NewsletterTemplateDto>();
            var entities = repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach(var entity in entities) { response.Add(new NewsletterTemplateDto(entity)); }    
            return response;
        }


        public NewsletterTemplateDto GetById(int id)
        {
            return new NewsletterTemplateDto(repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        protected readonly INewsletterUow uow;
        protected readonly IRepository<NewsletterTemplate> repository;
        protected readonly ICache cache;
    }
}
