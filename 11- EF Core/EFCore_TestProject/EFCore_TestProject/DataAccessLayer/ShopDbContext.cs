using EFCore_TestProject.Mapping;
using EFCore_TestProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_TestProject.DataAccessLayer
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new ProductCategoryMapping());
            modelBuilder.ApplyConfiguration(new AuthorMapping());
            modelBuilder.ApplyConfiguration(new AuthorBiographyMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}
