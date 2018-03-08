using CrecheBomPastor.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CrecheBomPastor.Infra.Data.EntityConfig
{
    class CollaboratorConfiguration : EntityTypeConfiguration<Collaborator>
    {
        public CollaboratorConfiguration()
        {
            HasKey(c => c.CollaboratorId);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(300);

            Property(c => c.PhotoUrl)
                .IsRequired()
                .HasMaxLength(500);

            Property(c => c.CollaboratorType)
                .IsRequired();

            Property(c => c.Description)
                .HasMaxLength(300);
        }
    }
}
