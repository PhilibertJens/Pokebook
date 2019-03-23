using AutoMapper;
using Pokebook.api.Data;
using Pokebook.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Repositories.Base
{
    public class MappingRepository<T> : Repository<T> where T : EntityBase
    {
        protected readonly IMapper mapper;
        public MappingRepository(PokebookContext context, IMapper mapper) :
            base(context)
        {
            this.mapper = mapper;
        }
    }
}
