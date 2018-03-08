using CrecheBomPastor.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CrecheBomPastor.Infra.Data.EntityConfig
{
    class EventConfiguration : EntityTypeConfiguration<Event>
    {
        public EventConfiguration()
        {
            HasKey(e => e.EventId);

            Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(150);

            Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(1000);

            Property(e => e.EventDate)
                .IsRequired();
        }
    }
}
