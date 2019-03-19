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
        private PokebookContext db;
        public ChatRepository(PokebookContext context) : base(context)
        {
            db = context;
        }
    }
}
