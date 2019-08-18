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
    public class PokemonTypeRepository : MappingRepository<PokemonType>, IPokemonTypeRepository
    {
        public PokemonTypeRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {
            this.context = context;
        }

        private PokebookContext context;
        
        public async Task<List<Pokemon>> GetPokemonListByTypeName(string typeName)
        {
            var givePokemonType = await PokebookContext.Set<PokemonType>()//deze method kan eigenlijk ook bij de PokemonRepository komen
                                            .Include(pt => pt.Pokemon)
                                            .Where(p => p.Type.Name.ToLower() == typeName.ToLower())
                                            .ToListAsync();

            List<Pokemon> pokeList = new List<Pokemon>();
            foreach(var el in givePokemonType)
            {
                el.Pokemon.PokemonTypes = null;//als dit niet gebeurt ontstaat er een serialize loop
                pokeList.Add(el.Pokemon);
            }
            return pokeList;
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
