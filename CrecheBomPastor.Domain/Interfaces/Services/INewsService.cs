using CrecheBomPastor.Domain.Entities;
using System.Collections.Generic;

namespace CrecheBomPastor.Domain.Interfaces.Services
{
    public interface INewsService : IServiceBase<News>
    {
        IEnumerable<News> FindByText(string text);
    }
}
