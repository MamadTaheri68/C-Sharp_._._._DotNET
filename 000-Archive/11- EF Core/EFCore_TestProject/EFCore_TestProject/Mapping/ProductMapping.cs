using EFCore_TestProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_TestProject.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(q => q.Id);
            
            builder.Property(q => q.Name).HasMaxLength(255).IsRequired();

            builder.Property(q => q.IsRemoved).HasColumnName("IsDeletedByFluentAPI");
            
            builder.Property(q => q.IsInStock).HasColumnName("AvailableInStockByFluentAPI");

            builder
                .HasOne(q => q.Category)
                .WithMany(q => q.Products)
                .HasForeignKey(q => q.CategoryId);

        }
    }
}
