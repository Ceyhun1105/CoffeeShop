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
    public class HistoryConfiguration:IEntityTypeConfiguration<History>
    {
        public void Configure(EntityTypeBuilder<History> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("GETUTCDATE()");
            builder.Property(x=> x.Title).IsRequired().HasMaxLength(50);
            builder.Property(x=> x.Desc).IsRequired().HasMaxLength(300);

            builder.Property(x=>x.Image1Url).HasMaxLength(300);
            builder.Property(x=>x.Image2Url).HasMaxLength(300);
            builder.Ignore(x => x.Image1);  
            builder.Ignore(x => x.Image2);
        }
    }
}
