using EFCoreProject.Domain.ProductAgg;
using EFCoreProject.Domain.ProductCategoryAgg;
using EFCoreProject.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace EFCoreProject.Infrastructure.EFCore
{
    public class EFContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public EFContext(DbContextOptions<EFContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ProductMapping());
            //modelBuilder.ApplyConfiguration(new ProductCategoryMapping());

            var assembly = typeof(ProductCategory).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}