using EFCoreProject.Domain.ProductCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreProject.Infrastructure.EFCore.Mapping
{
    public class ProductCategoryMapping : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");
            builder.HasKey(x => x.Id);
            builder.Property(q => q.Name).HasMaxLength(255).IsRequired();

            builder
                .HasMany(q => q.Products)
                .WithOne(q => q.Category)
                .HasForeignKey(q => q.CategoryId);
        }
    }
}
