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
            Pokemons = new PokemonRepository(context, mapper);
            PokemonCatches = new PokemonCatchRepository(context, mapper);
            Types = new TypeRepository(context, mapper);
            Moves = new MoveRepository(context, mapper);
            PokemonUsers = new PokemonUserRepository(context, mapper);
            PokemonTypes = new PokemonTypeRepository(context, mapper);
            PokemonMoveCatches = new PokemonMoveCatchRepository(context, mapper);
            PokemonMoves = new PokemonMoveRepository(context, mapper);
            PokemonCatchDeleted = new PokemonCatchDeletedRepository(context, mapper);
        }

        public IChatRepository Chats { get; }
        public IMessageRepository Messages { get; }
        public IUserChatRepository UserChats { get; }
        public IUserRepository Users { get; }
        public IFriendshipRepository Friendships { get; }
        public IPokemonRepository Pokemons { get; }
        public IPokemonCatchRepository PokemonCatches { get; }
        public ITypeRepository Types { get; }
        public IMoveRepository Moves { get; }
        public IPokemonUserRepository PokemonUsers { get; }
        public IPokemonTypeRepository PokemonTypes { get; }
        public IPokemonMoveCatchRepository PokemonMoveCatches { get; }
        public IPokemonMoveRepository PokemonMoves { get; }
        public IPokemonCatchDeletedRepository PokemonCatchDeleted { get; }

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
