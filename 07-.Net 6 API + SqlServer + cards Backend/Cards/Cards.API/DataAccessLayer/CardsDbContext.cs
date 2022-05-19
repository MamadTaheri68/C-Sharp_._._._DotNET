using Cards.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cards.API.DataAccessLayer
{
    public class CardsDbContext : DbContext
    {
        public CardsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }
    }
}
