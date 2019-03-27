using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pokebook.api.Data;
using Pokebook.api.Models;
using Pokebook.api.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Repositories
{
    public class ChatRepository : MappingRepository<Chat>
    {
        public ChatRepository(PokebookContext context, IMapper mapper) : 
            base(context, mapper)
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
            return await db.UserChats
                .Include(uc => uc.Chat).ThenInclude(c => c.UserChats)
                .Include(uc => uc.User).ThenInclude(u => u.UserChats)
                .Where(uc => uc.User.Id == Id)
                .Select(x => x.Chat).ToListAsync();

            //var userChats = await GetUserChats();
            //return userChats.Where(uc => uc.User.Id == Id)
            //                .Select(uc => uc.Chat).ToList();
        }

        public async Task<List<Chat>> GetChatsForUser(string username)
        {
            var userChats = await GetUserChats();
            return userChats.Where(uc => uc.User.UserName == username)
                            .Select(uc => uc.Chat).ToList();
        }

        public async Task<List<Guid>> GetChatIdForUser(Guid Id)
        {
            List<Chat> chatList = await GetChatsForUser(Id);
            return chatList.Select(x => x.Id).ToList();
        }

        public async Task<Chat> AddNewChat(Chat newChat)
        {
            UserChat senderData = new UserChat
            {
                Chat = newChat,
                ChatId = newChat.Id,
                UserId = newChat.CreatorId
            };

            UserChat receiverData = new UserChat
            {
                Chat = newChat,
                ChatId = newChat.Id,
                UserId = Guid.Parse("00000000-0000-0000-0000-000000000004")
            };

            //Message message = new Message
            //{
            //    Text = newChat.LastMessage,
            //    Chat = newChat,
            //    ChatId = newChat.Id,
            //    SenderId = newChat.CreatorId,
            //    SendDate = DateTime.Now,
            //    Id = Guid.Parse("00000000-0000-0000-0000-000000000004")
            //};

            //Chat addedChat = await Add(newChat);//new chat
            //UserChat userChat = new UserChat();//new userchat linked to sender and chat
            //Message message = new Message();//first message linked to chat
            Chat addedChat = await Add(newChat);
            db.Add(senderData);
            db.Add(receiverData);
            //db.Add(message);
            //await db.SaveChangesAsync(); --> Dit is niet mogelijk
            return addedChat;
        }
    }
}
