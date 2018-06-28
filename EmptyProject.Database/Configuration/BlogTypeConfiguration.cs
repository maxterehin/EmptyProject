using EmptyProject.Database.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmptyProject.Database.Configuration
{
    public class BlogTypeConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(b => b.Name)
                .HasMaxLength(250);

            builder.HasKey(d => d.Id);
        }
    }
}
