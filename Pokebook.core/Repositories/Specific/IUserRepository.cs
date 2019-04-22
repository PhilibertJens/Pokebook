using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User FindUserById(Guid Id);
        User FindUserByUserName(string userName);
        User UpdateUser(User user);
    }
}
