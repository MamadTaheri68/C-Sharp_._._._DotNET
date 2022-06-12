using Microsoft.EntityFrameworkCore;
using OnlinesShop.Core.Entities;
using OnlinesShop.Infrastructure.FluentApiConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinesShop.Infrastructure.Contexts
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext(DbContextOptions options): base(options) { }
        
        public DbSet<Product> Products => Set<Product>();    //public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
        }
    } 
}
