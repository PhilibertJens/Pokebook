using Microsoft.EntityFrameworkCore;
using Pokebook.api.Data;
using Pokebook.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Repositories
{
    public class ChatRepository : Repository<Chat>
    {
        private PokebookContext db;
        public ChatRepository(PokebookContext context) : base(context)
        {
            db = context;
        }

        public async Task<List<Chat>> GetChatsForUser(Guid Id)
        {
            return await db.UserChats
                .Include(uc => uc.Chat).ThenInclude(c => c.UserChats)
                .Include(uc => uc.User).ThenInclude(u => u.UserChats)
                .Where(uc => uc.User.Id == Id)
                .Select(x => x.Chat).ToListAsync();
        }
    }
}
