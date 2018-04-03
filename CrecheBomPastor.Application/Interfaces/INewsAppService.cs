using CrecheBomPastor.Domain.Entities;
using System.Collections.Generic;

namespace CrecheBomPastor.Application.Interfaces
{
    public interface INewsAppService : IAppServiceBase<News>
    {
        IEnumerable<News> FindByText(string text);
    }
}
