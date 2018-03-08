using AutoMapper;
using CrecheBomPastor.Domain.Entities;
using CrecheBomPastor.MVC.ViewModels;

namespace CrecheBomPastor.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<News, NewsViewModel>();
            CreateMap<Event, EventViewModel>();
            CreateMap<EventPhoto, EventPhotoViewModel>();
            CreateMap<Feedback, FeedbackViewModel>();
            CreateMap<Collaborator, CollaboratorViewModel>();
        }
    }
}