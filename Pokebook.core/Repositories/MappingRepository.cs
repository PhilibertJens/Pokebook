using AutoMapper;
using Pokebook.core.Data;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories
{
    public class MappingRepository<T> : GenericRepository<T> where T : EntityBase
    {
        protected readonly IMapper mapper;
        public MappingRepository(PokebookContext context, IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }
    }
}
