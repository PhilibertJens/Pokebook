using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Pokebook.api.Models;
using Pokebook.web.Helpers;
using Pokebook.web.Models;

namespace Pokebook.web.Controllers
{
    public class ChatController : Controller
    {
        string baseuri = "https://localhost:44321/api/chats";//poortnummer aanpassen!

        public IActionResult Index()
        {
            //var jsonString = "[" +
            //            "{'name': 'Awesome Chat','image': null,'theme': null,'creatorId': '00000000-0000-0000-0000-000000000000','createDate': '2019-03-19T11:51:57.857','numberOfMessages': 0,'numberOfUsers': 0,'lastMessage': null,'userChats': null,'messages': null,'id': '00000000-0000-0000-0000-000000000001'}," +
            //            "{'name': 'Another awesome Chat','image': null,'theme': null,'creatorId': '00000000-0000-0000-0000-000000000000','createDate': '2019-03-19T09:51:57.859','numberOfMessages': 0,'numberOfUsers': 0,'lastMessage': null,'userChats': null,'messages': null,'id': '00000000-0000-0000-0000-000000000002'}" +
            //            "]";
            //List<Chat> chatListForUser = JsonConvert.DeserializeObject <List<Chat>>(jsonString);

            Guid userId = Guid.Parse("00000000-0000-0000-0000-000000000001");//wordt via session opgehaald
            string uri = $"{baseuri}/userId/{userId}";
            List<Chat> chatListForUser = WebApiHelper.GetApiResult<List<Chat>>(uri);
            List<User> userList = new List<User>//moet opgehaald worden via de api
            {
                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    UserName = "otherUser"
                }
            };

            ChatIndexVM vm = new ChatIndexVM
            {
                AllUserChatsForUser = chatListForUser,
                User = new User { UserName = "UserWithNoName" },
                AllUsers = new SelectList(userList, "Id", "UserName")
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ChatIndexVM userdata)
        {
            return new RedirectToActionResult("SendFirstMessage", "Chat", null);
        }
    }
}