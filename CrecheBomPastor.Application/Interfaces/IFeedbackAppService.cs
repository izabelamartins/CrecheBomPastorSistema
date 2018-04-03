using CrecheBomPastor.Domain.Entities;
using System.Collections.Generic;

namespace CrecheBomPastor.Application.Interfaces
{
    public interface IFeedbackAppService : IAppServiceBase<Feedback>
    {
        IEnumerable<Feedback> GetAllContactUs();
        IEnumerable<Feedback> GetAllWorkWithUs();
    }
}
