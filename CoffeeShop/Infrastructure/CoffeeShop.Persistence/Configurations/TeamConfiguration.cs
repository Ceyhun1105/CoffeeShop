using CoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Persistence.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("GETUTCDATE()");

            builder.Property(x => x.Proffesional).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Desc).IsRequired().HasMaxLength(300);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.ImageUrl).HasMaxLength(300);
            builder.Ignore(x => x.Image);
        }
    }
}
