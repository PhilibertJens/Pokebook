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
    public class PokemonMoveCatchRepository : MappingRepository<PokemonMoveCatch>, IPokemonMoveCatchRepository
    {
        public PokemonMoveCatchRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
