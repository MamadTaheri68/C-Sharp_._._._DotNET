using Contacts.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Contacts.API.DataAccessLayer
{
    public class ContactAPIDbContext : DbContext
    {
        public ContactAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
