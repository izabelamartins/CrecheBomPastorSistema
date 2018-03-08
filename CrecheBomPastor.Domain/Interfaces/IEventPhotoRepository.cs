using CrecheBomPastor.Domain.Entities;
using System.Collections.Generic;

namespace CrecheBomPastor.Domain.Interfaces
{
    public interface IEventPhotoRepository : IRepositoryBase<EventPhoto>
    {
        IEnumerable<EventPhoto> FindByEvent(Event e);
    }
}
