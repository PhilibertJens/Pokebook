using Microsoft.AspNetCore.Http;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class ProfileFriendVM
    {
        public User me { get; set; }
        
        public IFormFile UploadedProfileImage { get; set; }
        public IFormFile UploadedCoverImage { get; set; }

        public string ProfilePicture { get; set; }
        public string CoverPicture { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string FavoritePokemon { get; set; }

        public string FavoritePokemonGame { get; set; }

        public ICollection<User> Friends { get; set; }

        public bool UserIsFriend { get; set; }
    }
}
