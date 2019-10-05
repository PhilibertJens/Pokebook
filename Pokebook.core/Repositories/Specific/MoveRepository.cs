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
    public class MoveRepository : MappingRepository<Move>, IMoveRepository
    {
        public MoveRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public Task<Move> GetByType(Guid typeId)
        {
            return PokebookContext.Moves.Where(m => m.TypeId == typeId).FirstOrDefaultAsync();
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
