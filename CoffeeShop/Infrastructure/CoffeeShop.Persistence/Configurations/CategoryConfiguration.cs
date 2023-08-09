using CoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
	public void Configure(EntityTypeBuilder<Category> builder)
	{
        builder.HasKey(x => x.Id);
        builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("GETUTCDATE()");
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

        // connections
        /*builder.HasMany(p => p.Products).WithOne(r=>r.Category).HasForeignKey(r => r.CategoryId);*/
    }
}
