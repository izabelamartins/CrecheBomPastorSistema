using System;
using System.Collections.Generic;

namespace CrecheBomPastor.Domain.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public virtual IEnumerable<EventPhoto> EventPhotos{ get; set; }
    }
}
