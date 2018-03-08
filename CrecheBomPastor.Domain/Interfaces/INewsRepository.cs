using CrecheBomPastor.Domain.Entities;
using System.Collections.Generic;

namespace CrecheBomPastor.Domain.Interfaces
{
    public interface INewsRepository : IRepositoryBase<News>
    {
        IEnumerable<News> FindByText(string text);
    }
}
