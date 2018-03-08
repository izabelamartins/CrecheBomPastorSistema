using CrecheBomPastor.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CrecheBomPastor.Infra.Data.EntityConfig
{
    public class EventPhotoConfiguration : EntityTypeConfiguration<EventPhoto>
    {
        public EventPhotoConfiguration()
        {
            HasKey(ep => ep.PhotoId);

            Property(ep => ep.PhotoUrl)
                .IsRequired()
                .HasMaxLength(500);

            HasRequired(ep => ep.Event)
                .WithMany()
                .HasForeignKey(ep => ep.EventId);
        }
    }
}
