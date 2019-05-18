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

        private bool CheckRange(int startMessage, int numberOfMessages, int totalLength)
        {
            if (startMessage < 0 || numberOfMessages < 0) return false;
            if (startMessage > totalLength) return false;
            return true;
        }

        public List<Message> GetMessageRange(Guid chatId, int startMessage, int numberOfMessages)
        {
            List<Message> messagesList = GetByChatId(chatId);
            int totalLength = messagesList.Count;
            messagesList.Reverse();
            if(CheckRange(startMessage, numberOfMessages, totalLength)){
                if ((startMessage + numberOfMessages) >= totalLength) messagesList = messagesList.Skip(startMessage).ToList();
                else messagesList = messagesList.GetRange(startMessage, numberOfMessages);//vb. 20 eerdere berichten
                messagesList.Reverse();
                return messagesList;
            }
            return new List<Message>();
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
