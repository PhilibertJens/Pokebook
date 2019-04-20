using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, Guid chatId)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, chatId);
        }
    }
}
