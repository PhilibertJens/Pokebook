using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public interface IUserChatRepository : IRepository<UserChat>
    {
        IEnumerable<UserChat> GetUserChatsForUser(Guid id);
        IEnumerable<UserChat> GetUserChatsForChat(Guid id);
    }
}
