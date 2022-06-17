using Microsoft.EntityFrameworkCore;
using OnlineShop_Deram.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop_Deram.Infrastructure
{
    public class OnlineShopDbContext: DbContext
    {
        public OnlineShopDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
