using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokebook.core.Data;
using Pokebook.core.Repositories.Specific;

namespace Pokebook.core.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly PokebookContext context;
        public UnitOfWork(PokebookContext _context)
        {
            context = _context;
            Chats = new ChatRepository(context);
        }

        public IChatRepository Chats { get; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
