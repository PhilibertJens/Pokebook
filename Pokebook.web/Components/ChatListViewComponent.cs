using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pokebook.core.Models;
using Pokebook.web.Helpers;
using Pokebook.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Components
{
    public class ChatListViewComponent : ViewComponent
    {
        public ChatListViewComponent()
        {
            Constants constants = new Constants();
            baseuri = $"https://localhost:{constants.Portnumber}/api";
        }

        string baseuri;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Guid userId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            string uri = $"{baseuri}/chats/userId/{userId}";
            List<Chat> chatListForUser = WebApiHelper.GetApiResult<List<Chat>>(uri);

            uri = $"{baseuri}/users/{userId}";
            User currentUser = WebApiHelper.GetApiResult<User>(uri);

            AllChatsForUserVM vm = new AllChatsForUserVM
            {
                ListChats = chatListForUser,
                Username = currentUser.UserName
            };
            return View(vm);
        }
    }
}
