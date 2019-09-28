using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pokebook.core.Data;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public class PokemonRepository : MappingRepository<Pokemon>, IPokemonRepository
    {
        public PokemonRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<List<Pokemon>> GetAllWithType()
        {
            var allPokemon = await PokebookContext.Pokemons
                                .Include(p => p.PokemonTypes)
                                .ThenInclude(pt => pt.Type).ToListAsync();

            var tempPokemon = new List<Pokemon>();
            foreach (var pokemon in allPokemon)
            {
                var types = pokemon.PokemonTypes;
                foreach(var type in types)
                {
                    type.Pokemon = null;
                    type.Type.PokemonTypes = null;
                }
            }

            return allPokemon;
        }

        public async Task<Pokemon> GetByName(string name)
        {
            return await PokebookContext.Pokemons.Where(p => p.Name == name).FirstOrDefaultAsync();
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
