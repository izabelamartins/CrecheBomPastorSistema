using CrecheBomPastor.Domain.Entities;
using System.Collections.Generic;

namespace CrecheBomPastor.Domain.Interfaces.Repositories
{
    public interface IEventPhotoRepository : IRepositoryBase<EventPhoto>
    {
        IEnumerable<EventPhoto> FindByEvent(Event e);
    }
}
