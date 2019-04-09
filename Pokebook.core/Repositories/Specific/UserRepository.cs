using AutoMapper;
using Pokebook.core.Data;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokebook.core.Repositories.Specific
{
    public class UserRepository : MappingRepository<User>, IUserRepository
    {
        public UserRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public User FindUserById(Guid Id)
        {
            return PokebookContext.Users.Find(Id);
        }

        public User FindUserByUserName(string userName)
        {
            return PokebookContext.Users.Where(u => u.UserName.Equals(userName)).FirstOrDefault();
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
