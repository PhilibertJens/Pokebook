﻿using Pokebook.core.Repositories.Specific;
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
        IMessageRepository Messages { get; }
        IUserChatRepository UserChats { get; }
        IUserRepository Users { get; }
        IFriendshipRepository Friendships { get; }
        IPokemonRepository Pokemons { get; }
        IPokemonCatchRepository PokemonCatches { get; }
        ITypeRepository Types { get; }
        IMoveRepository Moves { get; }
        IPokemonUserRepository PokemonUsers { get; }
        IPokemonTypeRepository PokemonTypes { get; }
        IPokemonMoveCatchRepository PokemonMoveCatches { get; }
        IPokemonMoveRepository PokemonMoves { get; }
        IPokemonCatchDeletedRepository PokemonCatchDeleted { get; }
        int Complete();
    }
}
