using System;
using System.Collections.Generic;

namespace CrecheBomPastor.Domain.Entities
{
    public class News
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
