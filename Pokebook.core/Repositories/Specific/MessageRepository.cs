using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pokebook.core.Data;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public class MessageRepository : MappingRepository<Message>, IMessageRepository
    {
        public MessageRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public List<Message> GetByChatId(Guid chatId)
        {
            var test = PokebookContext.Messages
                        .Include(m => m.Sender)
                        .Where(m => m.ChatId.Equals(chatId))
                        .ToList();

            return test;
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
