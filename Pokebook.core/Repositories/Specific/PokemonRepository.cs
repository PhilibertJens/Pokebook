using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Pokebook.core.Models.Type;

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

        public async Task<List<string>> GetAllNames()
        {
            return await PokebookContext.Pokemons
                                .Select(p => p.Name).ToListAsync();
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

            Pokemon pokemon = await PokebookContext.Pokemons.Where(p => p.Id == id)
                                        .Include(p => p.PokemonMoves).ThenInclude(pm => pm.Move)
                                        .Include(p => p.PokemonTypes).ThenInclude(pt => pt.Type).ThenInclude(t => t.AdvantagesOver)
                                        .Include(p => p.PokemonTypes).ThenInclude(pt => pt.Type).ThenInclude(t => t.DisadvantagesOver)
                                        .Include(p => p.PokemonEvolutions).ThenInclude(pe => pe.Evolution)
                                        .Include(p => p.PokemonPreEvolutions).ThenInclude(pre => pre.BasePokemon)
                                        .FirstOrDefaultAsync();

            pokemon = AvoidSerializeError(pokemon);
            pokemon = AvoidSerializeErrorAdvantages(pokemon);
            return pokemon;
        }

        private Pokemon AvoidSerializeErrorAdvantages(Pokemon pokemon)
        {
            List<PokemonType> types = pokemon.PokemonTypes.ToList();
            foreach(PokemonType pt in types)
            {
                Type type = pt.Type;

                var advantages = type.AdvantagesOver;
                foreach(var adv in advantages)
                {
                    adv.AdvantageType = null; adv.DisadvantageType = null;
                }

                var disadvantages = type.DisadvantagesOver;
                foreach (var disadv in disadvantages)
                {
                    disadv.AdvantageType = null; disadv.DisadvantageType = null;
                }
            }
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

        public async Task<PokemonSimpleDTO> GetPokemonSimple(Guid id)
        {
            return await PokebookContext.Pokemons.Where(p => p.Id == id)
                                  .ProjectTo<PokemonSimpleDTO>(mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }

        public async Task<PokemonSimpleDTO> GetPokemonSimple(string name)
        {
            return await PokebookContext.Pokemons.Where(p => p.Name == name)
                                  .ProjectTo<PokemonSimpleDTO>(mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }

        public async Task<List<Pokemon>> GetPokemonWithProperty(SearchObject obj)
        {
            string value = obj.Values.ElementAt(0);

            value = value.ToLower();
            List<Pokemon> pokemon = await GetAllWithType();
            List<Pokemon> toReturn = new List<Pokemon>();
            foreach (var poke in pokemon)
            {
                if (poke.Name.ToLower().Contains(value))
                {
                    toReturn.Add(poke);
                }
            }
            return toReturn;
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
