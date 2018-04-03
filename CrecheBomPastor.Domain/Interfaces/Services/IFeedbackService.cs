using CrecheBomPastor.Domain.Entities;
using System.Collections.Generic;

namespace CrecheBomPastor.Domain.Interfaces.Services
{
    public interface IFeedbackService : IServiceBase<Feedback>
    {
        IEnumerable<Feedback> GetAllContactUs();
        IEnumerable<Feedback> GetAllWorkWithUs();
    }
}
