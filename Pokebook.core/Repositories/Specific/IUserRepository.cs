using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> FindUserById(Guid Id);
        Task<User> FindUserByUserName(string userName);
        User UpdateUser(User user);
        Task<UserSimpleDTO> GetUserSimple(Guid Id);
        Task<List<UserSimpleDTO>> GetUsersSimple();
        Task<List<UserSimpleDTO>> GetChatUsersSimple(Guid chatId);
        List<User> GetChatUsers(Guid chatId);
        List<User> GetRemainingUsers(Guid chatId);
        List<UserSimpleDTO> GetRemainingUsersSimple(Guid chatId);
    }
}
