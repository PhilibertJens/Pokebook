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
            await Clients.Group(chatId.ToString()).SendAsync("ReceiveMessage", user, message);
            await Clients.Group(chatId.ToString()).SendAsync("ReceiveNotification", user, message, chatId);
        }

        public async Task JoinChat(string chatName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatName);
        }

        public async Task LeaveChat(string chatName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, chatName);
        }
    }
}
