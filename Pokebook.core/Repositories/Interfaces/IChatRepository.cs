using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Interfaces
{
    public interface IChatRepository : ICanReadEntity<Chat>,ICanCreateEntity<Chat>
    {
        
    }
}
