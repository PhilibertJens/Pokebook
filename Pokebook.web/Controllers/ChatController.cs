using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pokebook.core.Models;
using Pokebook.web.Helpers;
using Pokebook.web.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pokebook.web.Controllers
{
    public class ChatController : Controller
    {
        string baseuri = "https://localhost:44321/api";//poortnummer aanpassen!

        public IActionResult Index()
        {
            //var jsonString = "[" +
            //            "{'name': 'Awesome Chat','image': null,'theme': null,'creatorId': '00000000-0000-0000-0000-000000000000','createDate': '2019-03-19T11:51:57.857','numberOfMessages': 0,'numberOfUsers': 0,'lastMessage': null,'userChats': null,'messages': null,'id': '00000000-0000-0000-0000-000000000001'}," +
            //            "{'name': 'Another awesome Chat','image': null,'theme': null,'creatorId': '00000000-0000-0000-0000-000000000000','createDate': '2019-03-19T09:51:57.859','numberOfMessages': 0,'numberOfUsers': 0,'lastMessage': null,'userChats': null,'messages': null,'id': '00000000-0000-0000-0000-000000000002'}" +
            //            "]";
            //List<Chat> chatListForUser = JsonConvert.DeserializeObject <List<Chat>>(jsonString);

            Guid userId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            string uri = $"{baseuri}/chats/userId/{userId}";
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
            //ontvanger id moet in een session bijgehouden worden
            return new RedirectToActionResult("SendFirstMessage", "Chat", null);
        }

        public IActionResult SendFirstMessage()
        {
            ChatSendFirstMessageVM vm = new ChatSendFirstMessageVM()
            {
                //ophaling van ontvanger id uit session
                Receiver = new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    UserName = "otherUser"
                }
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendFirstMessage(ChatSendFirstMessageVM vm)
        {
            Chat chat = new Chat
            {
                Name = "Newly created Chat",//moet initieel een combinatie van de gebruikersnamen worden
                CreatorId = Guid.Parse(HttpContext.Session.GetString("UserId")),
                CreateDate = DateTime.Now,
                LastMessage = vm.Text,
                NumberOfUsers = 2, //minimum
                NumberOfMessages = 1 //bij het maken van de chat is er steeds 1 message aan gekoppeld
            };

            string uri = $"{baseuri}/chats";
            Chat createdChat = await WebApiHelper.PostCallAPI<Chat, Chat>(uri, chat);

            Message message = new Message
            {
                Text = createdChat.LastMessage,
                //Chat = createdChat,--> Navigation properties geven een error bij post request
                ChatId = createdChat.Id,
                SenderId = createdChat.CreatorId,
                SendDate = DateTime.Now
            };
            uri = $"{baseuri}/messages";
            Message createdMessage = await WebApiHelper.PostCallAPI<Message, Message>(uri, message);

            UserChat senderData = new UserChat
            {
                //Chat = createdChat,
                ChatId = createdChat.Id,
                UserId = createdChat.CreatorId
            };
            uri = $"{baseuri}/userchats";
            UserChat uc1 = await WebApiHelper.PostCallAPI<UserChat, UserChat>(uri, senderData);

            UserChat receiverData = new UserChat
            {
                ChatId = createdChat.Id,
                UserId = Guid.Parse("00000000-0000-0000-0000-000000000003")
            };
            UserChat uc2 = await WebApiHelper.PostCallAPI<UserChat, UserChat>(uri, receiverData);

            return new RedirectToActionResult("Index", "Chat", null);
        }
    }
}