﻿using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Chat>> GetChatsForUser(Guid Id)
        {
            var userChats = await GetUserChats();
            return userChats.Where(uc => uc.User.Id == Id)
                            .Select(uc => uc.Chat)
                            .ToList();
        }

        public async Task<List<Chat>> GetChatsForUser(string username)
        {
            var userChats = await GetUserChats();
            return userChats.Where(uc => uc.User.UserName == username)
                            .Select(uc => uc.Chat)
                            .ToList();
        }

        public async Task<List<Guid>> GetChatIdForUser(Guid Id)
        {
            List<Chat> chatList = await GetChatsForUser(Id);
            return chatList.Select(x => x.Id)
                           .ToList();
        }
    }
}
