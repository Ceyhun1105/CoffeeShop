using CoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Persistence.Configurations
{
    public class GalleryConfiguration : IEntityTypeConfiguration<Gallery>
    {
        public void Configure(EntityTypeBuilder<Gallery> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("GETUTCDATE()");
            builder.Ignore(x=>x.Image);
            builder.Property(x=>x.ImageUrl).HasMaxLength(300);
        }
    }
}
