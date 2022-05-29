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
        public OnlineShopDbContext(DbContextOptions options): base(options)
        {

        }
        
        public DbSet<Product> Products => Set<Product>();    //public DbSet<Product> Products { get; set; }

        public DbSet<Employee> Employees => Set<Employee>(); //public DbSet<Employee> Employees { get; set; }
        
        public DbSet<Supplier> Suppliers => Set<Supplier>(); //public DbSet<Supplier> Suppliers { get; set; }
        
        public DbSet<Customer> Customers => Set<Customer>(); //public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>()
            //    .Property(p => p.ProductName)
            //    .HasColumnName("Title")
            //    .IsRequired();

            //modelBuilder.Entity<Product>().ToTable("MyProduct");

            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
                
                
        }
    } 
}
