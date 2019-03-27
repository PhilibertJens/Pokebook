using AutoMapper;
using Pokebook.api.Data;
using Pokebook.api.Models;
using Pokebook.api.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Repositories
{
    public class UserChatRepository : MappingRepository<UserChat>
    {
        public UserChatRepository(PokebookContext context, IMapper mapper):
            base(context, mapper)
        {
        }
    }
}
