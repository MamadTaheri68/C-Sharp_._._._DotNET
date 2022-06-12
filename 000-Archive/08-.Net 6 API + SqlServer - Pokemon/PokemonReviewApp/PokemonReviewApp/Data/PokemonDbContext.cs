using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models.Entities;

namespace PokemonReviewApp.Data
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext(DbContextOptions<PokemonDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<PokemonOwner> PokemonOwners { get; set; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                .HasKey(q => new { q.PokemonId, q.CategoryId });
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(q => q.Pokemon)
                .WithMany(p => p.PokemonCategories)
                .HasForeignKey(s => s.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(q => q.Category)
                .WithMany(p => p.PokemonCategories)
                .HasForeignKey(s => s.CategoryId);

            modelBuilder.Entity<PokemonOwner>()
              .HasKey(q => new { q.PokemonId, q.OwnerId });
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(q => q.Pokemon)
                .WithMany(p => p.PokemonOwners)
                .HasForeignKey(s => s.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(q => q.Owner)
                .WithMany(p => p.PokemonOwners)
                .HasForeignKey(s => s.OwnerId);
        }
    }
}
