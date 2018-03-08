using AutoMapper;
using CrecheBomPastor.Domain.Entities;
using CrecheBomPastor.MVC.ViewModels;

namespace CrecheBomPastor.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<NewsViewModel, News>();
            CreateMap<EventViewModel, Event>();
            CreateMap<EventPhotoViewModel, EventPhoto>();
            CreateMap<FeedbackViewModel, Feedback>();
            CreateMap<CollaboratorViewModel, Collaborator>();
        }
    }
}