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

        public async Task<Pokemon> GetWithType(Guid id)
        {
            var pokemon = await PokebookContext.Pokemons
                                .Include(p => p.PokemonTypes).ThenInclude(pt => pt.Type)
                                .Where(p => p.Id == id).FirstOrDefaultAsync();

            foreach (var type in pokemon.PokemonTypes)
            {//serialize error vermijden
                type.Pokemon = null;
                type.Type.PokemonTypes = null;
            }
            return pokemon;
        }

        public async Task<List<Pokemon>> GetAllWithType()
        {
            var allPokemon = await PokebookContext.Pokemons
                                .Include(p => p.PokemonTypes)
                                .ThenInclude(pt => pt.Type).ToListAsync();

            foreach (var pokemon in allPokemon)
            {
                var types = pokemon.PokemonTypes;
                foreach(var type in types)
                {//serialize error vermijden
                    type.Pokemon = null;
                    type.Type.PokemonTypes = null;
                }
            }

            return allPokemon;
        }

        public async Task<Pokemon> GetByNdex(int ndex)
        {
            var pokemon = await PokebookContext.Pokemons
                .Include(p => p.PokemonTypes).ThenInclude(pt => pt.Type)
                .Where(p => p.NDex == ndex)
                .FirstOrDefaultAsync();

            foreach (var type in pokemon.PokemonTypes)
            {//serialize error vermijden
                type.Pokemon = null;
                type.Type.PokemonTypes = null;
            }

            return pokemon;
        }

        public async Task<Pokemon> GetByName(string name)
        {
            return await PokebookContext.Pokemons.Where(p => p.Name == name).FirstOrDefaultAsync();
        }

        public async Task<Pokemon> GetFullPokemon(Guid id)
        {
            /*
             select p.id, p.Name, p.ImgUrl, pAsEv.BasePokemonId, pAsPre.EvolutionId
             from Pokemons p
             join PokemonEvolutions pAsEv on p.Id = pAsEv.EvolutionId --> p is de evolved form. We vragen de base form op --> charmander
             join PokemonEvolutions pAsPre on p.Id = pAsPre.BasePokemonId --> p is de base form. We vragen de evolved form op --> charizard
             where p.Name = 'Charmeleon'
             */

            Pokemon pokemon = await PokebookContext.Pokemons.Where(p => p.Id == Guid.Parse("00000000-0000-0000-0000-000000000005"))
                                        .Include(p => p.PokemonMoves).ThenInclude(pm => pm.Move)
                                        .Include(p => p.PokemonTypes).ThenInclude(pt => pt.Type)
                                        .Include(p => p.PokemonEvolutions).ThenInclude(pe => pe.Evolution)
                                        .Include(p => p.PokemonPreEvolutions).ThenInclude(pre => pre.BasePokemon)
                                        .FirstOrDefaultAsync();

            pokemon = AvoidSerializeError(pokemon);
            return pokemon;
        }

        private Pokemon AvoidSerializeError(Pokemon pokemon)
        {
            foreach (PokemonEvolution pe in pokemon.PokemonEvolutions) pe.Evolution = null;
            foreach (PokemonEvolution pre in pokemon.PokemonPreEvolutions) pre.BasePokemon = null;
            foreach (PokemonType pt in pokemon.PokemonTypes)
            {
                pt.Type.PokemonTypes = null;
                pt.Pokemon = null;
            }
            foreach (PokemonMove pm in pokemon.PokemonMoves)
            {
                pm.Move.PokemonMoves = null;
                pm.Pokemon = null;
            }
            return pokemon;
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
