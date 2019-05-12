using Pokebook.core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class AllUsersVM
    {
        public List<UserSimpleDTO> AllUsers { get; set; }
    }
}
