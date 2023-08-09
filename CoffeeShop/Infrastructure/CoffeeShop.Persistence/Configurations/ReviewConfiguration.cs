using CoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Persistence.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.Property(x => x.Content).IsRequired().HasMaxLength(500);
            builder.Property(x => x.LikedCount).IsRequired();
            builder.Property(x => x.PinnedCount).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.ProductId).IsRequired();

            builder.HasKey(x => x.Id);  
            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("GETUTCDATE()");

            //Connections
            builder.HasOne(p => p.User).WithMany(d => d.Reviews).HasForeignKey(p => p.UserId);
            builder.HasOne(p => p.Product).WithMany(d => d.Reviews).HasForeignKey(p => p.ProductId);
        }
    }
}
