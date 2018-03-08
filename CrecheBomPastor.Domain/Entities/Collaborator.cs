using System;

namespace CrecheBomPastor.Domain.Entities
{
    public class Collaborator
    {
        public int CollaboratorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public CollaboratorType CollaboratorType { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    public enum CollaboratorType
    {
        Donor = 1,
        Voluntary = 2
    }
}
