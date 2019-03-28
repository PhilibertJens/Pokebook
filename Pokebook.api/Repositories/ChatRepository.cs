using Microsoft.EntityFrameworkCore;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Repositories;
using Pokebook.core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Repositories
{
    public class ChatRepository : GenericRepository<Chat>, IChatRepository
    {
        public ChatRepository(PokebookContext context) : base(context)
        {
        }

        public async Task<List<UserChat>> GetUserChats()
        {
            return await db.UserChats
                .Include(uc => uc.Chat).ThenInclude(c => c.UserChats)
                .Include(uc => uc.User).ThenInclude(u => u.UserChats)
                .ToListAsync();
        }

        //return await db.UserChats
        //    .Include(uc => uc.Chat).ThenInclude(c => c.UserChats)
        //    .Include(uc => uc.User).ThenInclude(u => u.UserChats)
        //    .Where(uc => uc.User.Id == Id)
        //    .Select(x => x.Chat).ToListAsync();

        public async Task<List<Chat>> FindChatsForUserAsync(Guid Id)
        {
            var userChats = await GetUserChats();
            return userChats.Where(uc => uc.User.Id == Id)
                            .Select(uc => uc.Chat)
                            .ToList();
        }

        public async Task<List<Chat>> FindChatsForUserAsync(string username)
        {
            var userChats = await GetUserChats();
            return userChats.Where(uc => uc.User.UserName == username)
                            .Select(uc => uc.Chat)
                            .ToList();
        }

        public async Task<List<Guid>> FindChatIdForUser(Guid Id)
        {
            List<Chat> chatList = await FindChatsForUserAsync(Id);
            return chatList.Select(x => x.Id)
                           .ToList();
        }

        public override async Task<Chat> AddAsync(Chat entity)
        {
            db.Set<Chat>().Add(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }
    }
}
