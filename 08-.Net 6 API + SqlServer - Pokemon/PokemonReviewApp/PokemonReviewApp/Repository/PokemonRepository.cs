using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models.Entities;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonDbContext _context;

        public PokemonRepository(PokemonDbContext pokemonDbContext)
        {
            _context = pokemonDbContext;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(q => q.Id).ToList();
        }
    }
}
