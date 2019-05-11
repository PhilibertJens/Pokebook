using AutoMapper;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokebook.core.Repositories.Specific
{
    public class FriendshipRepository : MappingRepository<Friendship>, IFriendshipRepository
    {
        public FriendshipRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {
            this.context = context;
        }

        private PokebookContext context;

        public List<Friendship> GetByUserId(Guid userid)
        {
            return context.Friendships
                    .Where(f => f.IdRequester == userid || f.IdApprover == userid).ToList();
        }

        public Friendship GetFriendship(Guid userId, Guid friendId)
        {
            return context.Friendships.Where
                (
                f => (f.IdRequester == userId && f.IdApprover == friendId)
                  || (f.IdRequester == friendId && f.IdApprover == userId)
                ).FirstOrDefault();
        }
    }
}
