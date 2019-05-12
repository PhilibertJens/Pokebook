using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Repositories.Specific
{
    public interface IFriendshipRepository
    {
        List<Friendship> GetByUserId(Guid userId);
        Friendship GetFriendship(Guid userId, Guid friendId);
        List<FriendshipDTO> GetFriendIdWithFriendshipDTOs(Guid userId);
    }
}
