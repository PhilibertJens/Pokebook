using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pokebook.api.Models;
using Pokebook.web.Models;

namespace Pokebook.web.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            var jsonString = "[" +
                        "{'name': 'Awesome Chat','image': null,'theme': null,'creatorId': '00000000-0000-0000-0000-000000000000','createDate': '2019-03-19T11:51:57.857','numberOfMessages': 0,'numberOfUsers': 0,'lastMessage': null,'userChats': null,'messages': null,'id': '00000000-0000-0000-0000-000000000001'}," +
                        "{'name': 'Another awesome Chat','image': null,'theme': null,'creatorId': '00000000-0000-0000-0000-000000000000','createDate': '2019-03-19T09:51:57.859','numberOfMessages': 0,'numberOfUsers': 0,'lastMessage': null,'userChats': null,'messages': null,'id': '00000000-0000-0000-0000-000000000002'}" +
                        "]";

            List<Chat> chatListForUser = JsonConvert.DeserializeObject <List<Chat>>(jsonString);
            ChatIndexVM vm = new ChatIndexVM
            {
                AllUserChatsForUser = chatListForUser
            };

            return View();
        }
    }
}