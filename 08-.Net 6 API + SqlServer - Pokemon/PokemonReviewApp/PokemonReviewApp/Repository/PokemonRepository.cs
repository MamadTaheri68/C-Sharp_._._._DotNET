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

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(q => q.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(q => q.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokemonId)
        {
            var review = _context.Reviews.Where(q => q.Pokemon.Id == pokemonId);
            if(review.Count() <= 0)
                return 0;

            return ((decimal)review.Sum(q => q.Rating) / review.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(q => q.Id).ToList();
        }

        public bool PokemonExists(int pokeId)
        {
            return _context.Pokemon.Any(q => q.Id == pokeId);
        }
    }
}
