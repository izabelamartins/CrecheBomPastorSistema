using System;

namespace CrecheBomPastor.Domain.Entities
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public SubjectType SubjectType { get; set; }
        public string Message { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    public enum SubjectType
    {
       ContactUs = 1,
       WorkWithUs = 2
    }
}
