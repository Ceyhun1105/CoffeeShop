using CoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Persistence.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("GETUTCDATE()");

            builder.Property(x=>x.Desc1).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.Desc2).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.ButtonTitle).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.ButtonUrl).IsRequired().HasMaxLength(300);
            builder.Ignore(x => x.Image1);     
            builder.Ignore(x => x.Image2);    
            builder.Ignore(x => x.Image3);
            builder.Property(x=>x.Image1Url).HasMaxLength(300);
            builder.Property(x=>x.Image2Url).HasMaxLength(300);
            builder.Property(x=>x.Image3Url).HasMaxLength(300);
        }
    }
}
