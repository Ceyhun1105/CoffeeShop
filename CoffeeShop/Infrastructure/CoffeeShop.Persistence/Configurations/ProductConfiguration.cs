using CoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Persistence.Configurations;

public class ProductConfiguration  : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("GETUTCDATE()");

        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(300);
        builder.Property(x => x.CategoryId).IsRequired();

        builder.Property(x => x.CostPrice).IsRequired();
        builder.Property(x => x.DiscountPercent).HasAnnotation("MaxValue",100);
        builder.Property(x => x.SalePrice).IsRequired();
 
        builder.Property(x=>x.SaledCount).IsRequired();

        // Connections

        builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
     /*   builder.HasMany(p => p.Ratings).WithOne(r => r.Product).HasForeignKey(p => p.ProductId);
        builder.HasMany(p => p.Reviews).WithOne(r => r.Product).HasForeignKey(p => p.ProductId);*/

    }


}
