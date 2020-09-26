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
    public class PokemonCatchDeletedRepository : MappingRepository<PokemonCatchDeleted>, IPokemonCatchDeletedRepository
    {
        public PokemonCatchDeletedRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {
            
        }

        public async Task<List<Guid>> GetAllGuids(Guid userId)
        {
            List<Guid> pokemonCatchGuids = await PokebookContext.PokemonCatchesDeleted.Where(pc => pc.UserId == userId)
                                                                               .Select(pc => pc.Id).ToListAsync();
            return pokemonCatchGuids;
        }

        public async Task<List<PokemonCatchDeleted>> GetAllPokemonCatchDeleted(Guid userId)
        {
            var pokemonList = await PokebookContext.PokemonCatchesDeleted
                        .Where(pc => pc.UserId == userId).ToListAsync();

            return pokemonList;
        }

        public Guid AddPokemonCatchDeleted(PokemonCatch toDelete)
        {
            PokemonCatchDeleted deleted = new PokemonCatchDeleted()
            {
                Id = toDelete.Id,
                PokemonId = toDelete.PokemonId,
                UserId = toDelete.UserId,
                HP = toDelete.HP,
                CurrentHP = toDelete.CurrentHP,
                CP = toDelete.CP,
                CurrentCP = toDelete.CurrentCP,
                Height = toDelete.Height,
                Weight = toDelete.Weight,
                //PokemonMoveCatches = toDelete.PokemonMoveCatches,
                Gender = toDelete.Gender,
                IsShiny = toDelete.IsShiny,
                IsAlolan = toDelete.IsAlolan,
                AppType = toDelete.AppType,
                FolderType = toDelete.FolderType,
                HPColor = toDelete.HPColor,
                CatchLocation = toDelete.CatchLocation,
                Nickname = toDelete.Nickname,
                Created = toDelete.Created,
                Deleted = DateTime.Now
            };

            PokebookContext.PokemonCatchesDeleted.Add(deleted);
            PokebookContext.SaveChanges();
            return toDelete.Id;
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
