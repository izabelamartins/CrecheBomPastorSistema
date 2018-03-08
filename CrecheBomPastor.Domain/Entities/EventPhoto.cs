using System;

namespace CrecheBomPastor.Domain.Entities
{
    public class EventPhoto
    {
        public int PhotoId { get; set; }
        public string PhotoUrl { get; set; }
        public int EventId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public virtual Event Event { get; set; }
    }
}
