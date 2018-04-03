using CrecheBomPastor.Application.Interfaces;
using CrecheBomPastor.Domain.Entities;
using CrecheBomPastor.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrecheBomPastor.Application
{
    public class FeedbackAppService : AppServiceBase<Feedback>, IFeedbackAppService
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackAppService(IFeedbackService feedbackService)
            : base(feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public IEnumerable<Feedback> GetAllContactUs()
        {
            return _feedbackService.GetAllContactUs();
        }

        public IEnumerable<Feedback> GetAllWorkWithUs()
        {
            return _feedbackService.GetAllWorkWithUs();
        }
    }
}
