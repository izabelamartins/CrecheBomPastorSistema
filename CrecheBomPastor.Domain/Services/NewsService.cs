using CrecheBomPastor.Domain.Entities;
using CrecheBomPastor.Domain.Interfaces.Repositories;
using CrecheBomPastor.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrecheBomPastor.Domain.Services
{
    public class NewsService : ServiceBase<News>, INewsService
    {
        private readonly INewsRepository _newsRepository;

        public NewsService(INewsRepository newsRepository)
            :base(newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public IEnumerable<News> FindByText(string text)
        {
            return _newsRepository.FindByText(text);
        }
    }
}
