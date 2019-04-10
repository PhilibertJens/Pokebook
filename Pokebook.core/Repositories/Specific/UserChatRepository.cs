using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Pokebook.core.Data;
using Microsoft.EntityFrameworkCore;

namespace Pokebook.core.Repositories.Specific
{
    public class UserChatRepository : MappingRepository<UserChat>, IUserChatRepository
    {
        public UserChatRepository(PokebookContext context, IMapper mapper) : base(context,mapper)
        {

        }

        public IEnumerable<UserChat> GetUserChatsForUser(Guid Id)
        {
            return PokebookContext.UserChats
                .Include(uc => uc.Chat).ThenInclude(c => c.UserChats)
                .Include(uc => uc.User).ThenInclude(u => u.UserChats)
                .Where(uc => uc.User.Id == Id).ToList();
        }

        public IEnumerable<UserChat> GetUserChatsForChat(Guid Id)
        {
            return PokebookContext.UserChats
                .Where(uc => uc.ChatId.Equals(Id)).ToList();
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
