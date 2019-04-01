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
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var jsonString = "[" +
            //            "{'name': 'Awesome Chat','image': null,'theme': null,'creatorId': '00000000-0000-0000-0000-000000000000','createDate': '2019-03-19T11:51:57.857','numberOfMessages': 0,'numberOfUsers': 0,'lastMessage': null,'userChats': null,'messages': null,'id': '00000000-0000-0000-0000-000000000001'}," +
            //            "{'name': 'Another awesome Chat','image': null,'theme': null,'creatorId': '00000000-0000-0000-0000-000000000000','createDate': '2019-03-19T09:51:57.859','numberOfMessages': 0,'numberOfUsers': 0,'lastMessage': null,'userChats': null,'messages': null,'id': '00000000-0000-0000-0000-000000000002'}" +
            //            "]";

            Guid userId = Guid.Parse("00000000-0000-0000-0000-000000000001");//wordt via session opgehaald
            string uri = $"https://localhost:44321/api/chats/userId/{userId}";
            List<Chat> chatListForUser = WebApiHelper.GetApiResult<List<Chat>>(uri);

            //List<Chat> chatListForUser = JsonConvert.DeserializeObject<List<Chat>>(jsonString);

            AllChatsForUserVM vm = new AllChatsForUserVM
            {
                ListChats = chatListForUser,
                Username = "Jens"
            };
            return View(vm);
        }
    }
}
