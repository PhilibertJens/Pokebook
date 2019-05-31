using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models.DTO
{
    public class UserSimpleProfileDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        /*Userprofile data*/
        public string ProfilePicture { get; set; }
        public string CoverPicture { get; set; }

        public string FavoritePokemon { get; set; }
        public string FavoritePokemonGame { get; set; }
    }
}
