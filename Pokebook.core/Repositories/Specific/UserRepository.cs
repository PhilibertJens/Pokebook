using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public class UserRepository : MappingRepository<User>, IUserRepository
    {
        public UserRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<User> FindUserById(Guid Id)
        {
            return await PokebookContext.Users.FindAsync(Id);
        }

        public async Task<User> FindUserByUserName(string userName)
        {
            return await PokebookContext.Users.Where(u => u.UserName.Equals(userName)).FirstOrDefaultAsync();
        }

        public User UpdateUser(User user)
        {
            PokebookContext.Users.Update(user);
            PokebookContext.SaveChanges();
            return user;
        }

        public async Task<UserSimpleDTO> GetUserSimple(Guid Id)
        {
            return await PokebookContext.Users.Where(u => u.Id == Id)
                                  .ProjectTo<UserSimpleDTO>(mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        
        public async Task<List<UserSimpleDTO>> GetUsersSimple()
        {
            return await PokebookContext.Users.ProjectTo<UserSimpleDTO>(mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<List<UserSimpleDTO>> GetChatUsersSimple(Guid chatId)
        {
            var userList = new List<UserSimpleDTO>();
            var allUserChats = PokebookContext.UserChats.Include(uc => uc.User).Where(uc => uc.ChatId == chatId).ToList();
            foreach (var uc in allUserChats)
            {
                UserSimpleDTO userToAddDTO = await GetUserSimple(uc.User.Id);
                userList.Add(userToAddDTO);
            }
            return userList;
        }

        public List<User> GetChatUsers(Guid chatId)
        {
            var userList = new List<User>();
            var allUserChats = PokebookContext.UserChats.Include(uc => uc.User).Where(uc => uc.ChatId == chatId).ToList();
            foreach (var uc in allUserChats) userList.Add(uc.User);
            return userList;
        }

        public async Task<UserSimpleProfileDTO> GetUserSimpleProfile(Guid Id)
        {
            return await PokebookContext.Users.Where(u => u.Id == Id)
                                  .ProjectTo<UserSimpleProfileDTO>(mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }

        public List<User> GetRemainingUsers(Guid chatId)
        {
            var userList = GetChatUsers(chatId);
            var allUsers = PokebookContext.Users.ToList();
            foreach (var user in userList)
            {
                User toRemove = allUsers.Where(a => a.UserName == user.UserName).FirstOrDefault();
                allUsers.Remove(toRemove);
            }
            return allUsers;
        }

        public List<UserSimpleDTO> GetRemainingUsersSimple(Guid chatId)
        {
            var allUsers = PokebookContext.Users.ProjectTo<UserSimpleDTO>(mapper.ConfigurationProvider).ToList();
            var userList = GetChatUsers(chatId);
            foreach (var user in userList)
            {
                UserSimpleDTO toRemove = allUsers.Where(a => a.UserName == user.UserName).FirstOrDefault();
                allUsers.Remove(toRemove);
            }
            return allUsers;
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
