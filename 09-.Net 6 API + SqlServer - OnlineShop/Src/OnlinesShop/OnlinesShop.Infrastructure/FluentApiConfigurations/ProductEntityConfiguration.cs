using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinesShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinesShop.Infrastructure.FluentApiConfigurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("ASO_*_Products");
            builder.HasKey(x => x.Id);
            builder.Property(q => q.ProductName)
                .HasColumnName("Titleeeeee")
                .HasMaxLength(256)
                .HasColumnOrder(1);
        }
    }
}
