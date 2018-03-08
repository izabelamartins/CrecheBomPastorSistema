using CrecheBomPastor.Domain.Entities;
using CrecheBomPastor.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrecheBomPastor.Infra.Data.Repositories
{
    public class EventPhotoRepository : RepositoryBase<EventPhoto>, IEventPhotoRepository
    {
        public IEnumerable<EventPhoto> FindByEvent(Event e)
        {
            return Db.EventPhotos.Where(ep => ep.EventId == e.EventId).ToList();
        }
    }
}
