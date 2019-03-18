using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Models
{
    public class User
    {//properties based on Identity AspNetUsers table
        public Guid Id { get; set; }
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

        /*Navigation properties*/
        public ICollection<UserChat> UserChats { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
