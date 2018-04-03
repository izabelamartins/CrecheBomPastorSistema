using CrecheBomPastor.Application.Interfaces;
using CrecheBomPastor.Domain.Entities;
using CrecheBomPastor.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CrecheBomPastor.Application
{
    public class NewsAppService : AppServiceBase<News>, INewsAppService
    {
        private readonly INewsService _newsService;

        public NewsAppService(INewsService newsService)
            :base(newsService)
        {
            _newsService = newsService;
        }

        public IEnumerable<News> FindByText(string text)
        {
            return _newsService.FindByText(text);
        }
    }
}
