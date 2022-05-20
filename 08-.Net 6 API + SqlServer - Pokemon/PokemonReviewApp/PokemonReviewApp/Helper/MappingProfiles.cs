using AutoMapper;
using PokemonReviewApp.Models.DTOs;
using PokemonReviewApp.Models.Entities;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
