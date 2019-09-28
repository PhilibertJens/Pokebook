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
    public class PokemonCatchRepository : MappingRepository<PokemonCatch>, IPokemonCatchRepository
    {
        public PokemonCatchRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<List<PokemonCatch>> GetAllCaughtPokemon(Guid userId)
        {
            return await PokebookContext.PokemonCatches.Where(pc => pc.UserId == userId).ToListAsync();
        }

        public Task<PokemonCatch> CreateByName(string name)
        {
            throw new NotImplementedException();
        }

        public PokemonCatch CreateFromTemplate(Pokemon template, Guid userId)
        {
            PokemonCatch pokemonCatch = null;
            if(template != null)
            {
                PokemonCatch pokemon = new PokemonCatch
                {
                    PokemonId = template.Id,
                    UserId = userId,
                    HP = GetRandomValue(template.MinHP, template.MaxHP),
                    CP = GetRandomValue(template.MinCP, template.MaxCP),
                    Height = GetRandomValue(template.MinHeight, template.MaxHeight),
                    Weight = GetRandomValue(template.MinWeight, template.MaxWeight)
                };
                pokemonCatch = pokemon;
            }
            return pokemonCatch;
        }

        public int GetRandomValue(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max+1);
        }

        public float GetRandomValue(float min, float max)
        {
            Random rand = new Random();
            double value = min + rand.NextDouble() * (max - min);
            return (float)value;
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
