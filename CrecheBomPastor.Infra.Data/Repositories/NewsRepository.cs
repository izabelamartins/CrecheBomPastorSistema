using System.Collections.Generic;
using System.Linq;
using CrecheBomPastor.Domain.Entities;
using CrecheBomPastor.Domain.Interfaces.Repositories;

namespace CrecheBomPastor.Infra.Data.Repositories
{
    public class NewsRepository : RepositoryBase<News>, INewsRepository
    {
        public IEnumerable<News> FindByText(string text)
        {
            return Db.News.Where(n => n.Title.Contains(text) || n.Description.Contains(text)).ToList();
        }
    }
}
