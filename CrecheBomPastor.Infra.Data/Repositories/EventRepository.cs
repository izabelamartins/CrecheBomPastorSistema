using CrecheBomPastor.Domain.Entities;
using CrecheBomPastor.Domain.Interfaces.Repositories;

namespace CrecheBomPastor.Infra.Data.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
    }
}
