
using CrecheBomPastor.Domain.Entities;
using CrecheBomPastor.Domain.Interfaces.Repositories;
using CrecheBomPastor.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CrecheBomPastor.Domain.Services
{
    public class FeedbackService : ServiceBase<Feedback>, IFeedbackService
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackService(IFeedbackRepository feedbackRepository)
            : base(feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public IEnumerable<Feedback> GetAllContactUs()
        {
            return _feedbackRepository.GetAllContactUs();
        }

        public IEnumerable<Feedback> GetAllWorkWithUs()
        {
            return _feedbackRepository.GetAllWorkWithUs();
        }
    }
}
