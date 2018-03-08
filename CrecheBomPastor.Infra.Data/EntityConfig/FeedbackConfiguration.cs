using CrecheBomPastor.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CrecheBomPastor.Infra.Data.EntityConfig
{
    public class FeedbackConfiguration : EntityTypeConfiguration<Feedback>
    {
        public FeedbackConfiguration()
        {
            HasKey(f => f.FeedbackId);

            Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(f => f.Email)
                .IsRequired()
                .HasMaxLength(150);

            Property(f => f.Subject)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.SubjectType)
                .IsRequired();

            Property(f => f.Message)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}
