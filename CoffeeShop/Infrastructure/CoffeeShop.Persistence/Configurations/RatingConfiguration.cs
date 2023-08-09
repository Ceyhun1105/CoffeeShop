using CoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Persistence.Configurations
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("GETUTCDATE()");


            
            builder.Property(x => x.RatingLevel).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.ProductId).IsRequired();

            // Connections
            builder.HasOne(p => p.User).WithMany(d => d.Ratings).HasForeignKey(p => p.UserId);
            builder.HasOne(p => p.Product).WithMany(d => d.Ratings).HasForeignKey(p => p.ProductId);
        }
    }
}
