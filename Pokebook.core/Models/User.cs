using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Models
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }

        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }
        public DateTime LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public int NumberOfFriends { get; set; }

        /*Userprofile data*/
        public string ProfilePicture { get; set; }
        public string CoverPicture { get; set; }
        //public List<string> StatusInfo { get; set; }

        public string FavoritePokemon { get; set; }
        public string FavoritePokemonGame { get; set; }

        /*Navigation properties*/
        [JsonIgnore]
        public ICollection<UserChat> UserChats { get; set; }
        [JsonIgnore]
        public ICollection<Message> Messages { get; set; }
        [JsonIgnore]
        public ICollection<Friendship> Friendships { get; set; }
    }
}
