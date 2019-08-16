using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokebook.core.Data;
using Pokebook.core.Repositories.Specific;
using AutoMapper;

namespace Pokebook.core.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly PokebookContext context;
        public UnitOfWork(PokebookContext _context, IMapper mapper)
        {
            context = _context;
            Chats = new ChatRepository(context,mapper);
            Messages = new MessageRepository(context, mapper);
            UserChats = new UserChatRepository(context, mapper);
            Users = new UserRepository(context, mapper);
            Friendships = new FriendshipRepository(context, mapper);
            PokemonCatches = new PokemonCatchRepository(context, mapper);
            Pokemons = new PokemonRepository(context, mapper);
        }

        public IChatRepository Chats { get; }
        public IMessageRepository Messages { get; }
        public IUserChatRepository UserChats { get; }
        public IUserRepository Users { get; }
        public IFriendshipRepository Friendships { get; }
        public IPokemonRepository Pokemons { get; }
        public IPokemonCatchRepository PokemonCatches { get; }

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
