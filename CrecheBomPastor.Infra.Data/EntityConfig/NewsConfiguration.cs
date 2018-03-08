using CrecheBomPastor.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CrecheBomPastor.Infra.Data.EntityConfig
{
    public class NewsConfiguration : EntityTypeConfiguration<News>
    {
        public NewsConfiguration()
        {
            HasKey(n => n.NewsId);

            Property(n => n.Title)
                .IsRequired()
                .HasMaxLength(500);

            Property(n => n.Description)
                .IsRequired()
                .HasMaxLength(5000);

            Property(n => n.PhotoUrl)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}
