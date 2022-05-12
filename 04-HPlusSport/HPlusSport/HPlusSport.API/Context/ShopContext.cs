using HPlusSport.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models
{
    public class ShopContext: DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            
        }

        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEntity>()
                .HasMany(q => q.Products)
                .WithOne(q => q.Category)
                .HasForeignKey(q => q.CategoryId);
            modelBuilder.Seed();
        }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
