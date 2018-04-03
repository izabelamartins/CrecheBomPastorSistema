using CrecheBomPastor.Domain.Entities;
using System.Collections.Generic;

namespace CrecheBomPastor.Domain.Interfaces.Repositories
{
    public interface IFeedbackRepository : IRepositoryBase<Feedback>
    {
        IEnumerable<Feedback> GetAllContactUs();
        IEnumerable<Feedback> GetAllWorkWithUs();
    }
}
