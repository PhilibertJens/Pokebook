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
            random = new Random();
        }

        private Random random;

        public async Task<List<PokemonCatch>> GetAllCaughtPokemon(Guid userId)
        {
            var pokemonList = await PokebookContext.PokemonCatches
                        .Where(pc => pc.UserId == userId).ToListAsync();

            return pokemonList;//de Pokemon property is null doordat er geen include gebeurt
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
                    Weight = GetRandomValue(template.MinWeight, template.MaxWeight),
                    PokemonMoveCatches = GetRandomMoveFromList(template.PokemonMoves),
                    Gender = GetRandomTrueOrFalse(1),//50% kans
                    IsShiny = GetRandomTrueOrFalse(99),//1% kans
                };
                if (template.HasAlolanForm) pokemon.IsAlolan = GetRandomTrueOrFalse(4);//20% kans

                pokemonCatch = pokemon;
            }
            return pokemonCatch;
        }

        private ICollection<PokemonMoveCatch> GetRandomMoveFromList(ICollection<PokemonMove> pokemonMoves)
        {
            int listItem = random.Next(0, pokemonMoves.Count);
            List<PokemonMoveCatch> list;
            if (pokemonMoves.Count > 0)
            {
                PokemonMove pokemonMove = pokemonMoves.ElementAt(listItem);
                PokemonMoveCatch moveCatch = new PokemonMoveCatch
                {
                    Move = pokemonMove.Move,
                    MoveId = pokemonMove.MoveId,
                    //PokemonId = pokemonMove.PokemonId
                };
                list = new List<PokemonMoveCatch>
                {
                    moveCatch
                };
            }
            else list = new List<PokemonMoveCatch>();
            return list;
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

        public bool GetRandomTrueOrFalse(int chance)
        {
            Random rand = new Random();
            int getal = random.Next(0, chance);
            return getal == 0;
        }

        public Guid AddPokemonCatch(PokemonCatch pokemon)
        {
            PokebookContext.PokemonCatches.Add(pokemon);
            PokebookContext.SaveChanges();
            return pokemon.Id;
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
