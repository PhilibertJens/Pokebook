using Pokebook.core.Data;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public class ChatRepository : GenericRepository<Chat>, IChatRepository
    {
        public ChatRepository(PokebookContext context) : base(context)
        {
        }

        public IEnumerable<UserChat> GetUserChats()
        {
            return PokebookContext.UserChats
                .Include(uc => uc.Chat).ThenInclude(c => c.UserChats)
                .Include(uc => uc.User).ThenInclude(u => u.UserChats)
                .ToList();
        }

        //return await db.UserChats
        //    .Include(uc => uc.Chat).ThenInclude(c => c.UserChats)
        //    .Include(uc => uc.User).ThenInclude(u => u.UserChats)
        //    .Where(uc => uc.User.Id == Id)
        //    .Select(x => x.Chat).ToListAsync();

        public IEnumerable<Chat> FindChatsForUser(Guid Id)
        {
            var userChats = GetUserChats();
            return userChats.Where(uc => uc.User.Id == Id)
                            .Select(uc => uc.Chat)
                            .ToList();
        }

        public IEnumerable<Chat> FindChatsForUser(string username)
        {
            var userChats = GetUserChats();
            return userChats.Where(uc => uc.User.UserName == username)
                            .Select(uc => uc.Chat)
                            .ToList();
        }

        public IEnumerable<string> FindChatNamesForUser(Guid Id)
        {
            IEnumerable<Chat> chatList = FindChatsForUser(Id);
            return chatList.Select(x => x.Name)
                           .ToList();
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
