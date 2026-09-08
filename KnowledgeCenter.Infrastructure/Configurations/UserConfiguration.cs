using KnowledgeCenter.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KnowledgeCenter.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) 
        {
            builder.ToTable("tb_Users");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasIndex(p => p.Email)
                .IsUnique();

            builder.Property(p => p.Document)
                .IsRequired()
                .HasMaxLength(14);
            builder.HasIndex(p => p.Document)
                .IsUnique();

            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(20);
        }
    }
}
