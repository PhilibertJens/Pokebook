using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public interface IMessageRepository : IRepository<Message>
    {
        List<Message> GetByChatId(Guid chatId);
        List<Message> GetMessageRange(Guid chatId, int startMessage, int numberOfMessages);
    }
}
