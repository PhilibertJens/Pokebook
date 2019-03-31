using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public interface IChatRepository : IRepository<Chat>
    {
        IEnumerable<Chat> FindChatsForUser(Guid id);
        IEnumerable<Chat> FindChatsForUser(string username);

        IEnumerable<string> FindChatNamesForUser(Guid id);
    }
}
