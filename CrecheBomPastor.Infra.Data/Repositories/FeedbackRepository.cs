using System.Collections.Generic;
using System.Linq;
using CrecheBomPastor.Domain.Entities;
using CrecheBomPastor.Domain.Interfaces.Repositories;

namespace CrecheBomPastor.Infra.Data.Repositories
{
    public class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository
    {
        public IEnumerable<Feedback> GetAllContactUs()
        {
            return Db.Feedbacks.Where(f => f.SubjectType == SubjectType.ContactUs).ToList();
        }

        public IEnumerable<Feedback> GetAllWorkWithUs()
        {
            return Db.Feedbacks.Where(f => f.SubjectType == SubjectType.WorkWithUs).ToList();
        }
    }
}
