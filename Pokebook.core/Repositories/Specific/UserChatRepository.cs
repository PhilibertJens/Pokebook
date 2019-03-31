using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Pokebook.core.Data;

namespace Pokebook.core.Repositories.Specific
{
    public class UserChatRepository : MappingRepository<UserChat>, IUserChatRepository
    {
        public UserChatRepository(PokebookContext context, IMapper mapper) : base(context,mapper)
        {

        }
    }
}
