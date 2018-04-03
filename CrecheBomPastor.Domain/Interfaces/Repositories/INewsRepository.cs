using CrecheBomPastor.Domain.Entities;
using System.Collections.Generic;

namespace CrecheBomPastor.Domain.Interfaces.Repositories
{
    public interface INewsRepository : IRepositoryBase<News>
    {
        IEnumerable<News> FindByText(string text);
    }
}
