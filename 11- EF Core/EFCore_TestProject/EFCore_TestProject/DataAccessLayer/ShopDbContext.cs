using EFCore_TestProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_TestProject.DataAccessLayer
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}
