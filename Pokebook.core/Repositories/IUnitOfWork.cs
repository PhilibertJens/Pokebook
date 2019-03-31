using Pokebook.core.Repositories.Specific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        //add every new repo to this
        IChatRepository Chats { get; }
        int Complete();
    }
}
