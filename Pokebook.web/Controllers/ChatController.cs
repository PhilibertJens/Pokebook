using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pokebook.core.Models;
using Pokebook.web.Helpers;
using Pokebook.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Controllers
{
    public class ChatController : Controller
    {
        string baseuri = "https://localhost:44321/api";//poortnummer aanpassen!

        public async Task<IActionResult> Index()
        {
            Guid userId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            string uri = $"{baseuri}/chats/userId/{userId}";
            List<Chat> chatListForUser = WebApiHelper.GetApiResult<List<Chat>>(uri);

            User currentUser = await GetUserWithId(userId);

            uri = $"{baseuri}/users";
            var allUsers = WebApiHelper.GetApiResult<List<User>>(uri);
            allUsers = await FilterUserList(allUsers, userId);

            ChatIndexVM vm = new ChatIndexVM
            {
                User = currentUser,
                AllUsers = new SelectList(allUsers, "Id", "UserName")
            };
            //HttpContext.Session.SetString("chatId", "9bc5f401-9684-48a9-2ffe-08d6bd9fc1a1");
            //return new RedirectToActionResult("OpenExistingChat", "Chat", null);
            return View(vm);
        }

        public async Task<User> GetUserWithId(Guid userId)
        {
            string uri = $"{baseuri}/users/{userId}";
            return WebApiHelper.GetApiResult<User>(uri);
        }

        private async Task<List<User>> FilterUserList(List<User> allUsers, Guid userId)
        {
            List<User> allOtherUsers = allUsers.Where(u => u.Id != userId).ToList();//eigen user verwijderen uit list

            List<Guid> IdForOtherUsers = allUsers.Where(u => u.Id != userId)
                                                 .Select(u => u.Id).ToList();//eigen userId verwijderen uit list

            string uri = $"{baseuri}/chats/userId/{userId}";
            List<Chat> chatListForUser = WebApiHelper.GetApiResult<List<Chat>>(uri);//alle huidige chats van de user

            var usersToRemoveById = new List<Guid>();
            foreach(var chat in chatListForUser)
            {
                uri = $"{baseuri}/userchats/chatId/{chat.Id}";
                List<UserChat> userChatListForChat = WebApiHelper.GetApiResult<List<UserChat>>(uri);//alle userchats van deze chat.
                //var userchats = chat.UserChats; --> kan niet door [JsonIgnore] in Chat class

                foreach (var uc in userChatListForChat)
                {
                    if (IdForOtherUsers.Contains(uc.UserId)) usersToRemoveById.Add(uc.UserId);//id's van te verwijderen users
                }
            }

            List<User> result = new List<User>();
            foreach (var user in allOtherUsers)
            {
                if (!usersToRemoveById.Contains(user.Id)) result.Add(user);//wanneer de userid niet voorkomt in lijst komt hij in result
            }
            
            return result;//enkel de gebruikers waarmee je nog geen gesprek bent gestart
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ChatIndexVM userdata)
        {
            HttpContext.Session.SetString("ReceiverId", userdata.SelectedUserId.ToString());
            return new RedirectToActionResult("SendFirstMessage", "Chat", null);
        }

        public async Task<IActionResult> SendFirstMessage()
        {
            Guid receiverId = Guid.Parse(HttpContext.Session.GetString("ReceiverId"));
            User receiver = await GetUserWithId(receiverId);

            Guid senderId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            User sender = await GetUserWithId(senderId);

            ChatSendFirstMessageVM vm = new ChatSendFirstMessageVM()
            {
                Receiver = receiver,
                Sender = sender
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendFirstMessage(ChatSendFirstMessageVM vm)
        {
            Guid receiverId = Guid.Parse(HttpContext.Session.GetString("ReceiverId"));
            User receiver = await GetUserWithId(receiverId);

            Guid senderId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            User sender = await GetUserWithId(senderId);

            if (ModelState.IsValid)
            {
                Chat chat = new Chat
                {
                    Name = $"{sender.UserName}, {receiver.UserName}",
                    CreatorId = sender.Id,
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
                    ChatId = createdChat.Id,
                    UserId = createdChat.CreatorId
                };
                uri = $"{baseuri}/userchats";
                UserChat uc1 = await WebApiHelper.PostCallAPI<UserChat, UserChat>(uri, senderData);

                UserChat receiverData = new UserChat
                {
                    ChatId = createdChat.Id,
                    UserId = receiver.Id
                };
                UserChat uc2 = await WebApiHelper.PostCallAPI<UserChat, UserChat>(uri, receiverData);

                HttpContext.Session.SetString("ChatId", createdChat.Id.ToString());
                return new RedirectToActionResult("OpenExistingChat", "Chat", createdChat.Id);
            }
            vm.Receiver = receiver;
            return View(vm);
        }

        public async Task<IActionResult> OpenExistingChat(Guid chatId)//is 000... na Redirect om de een of andere reden
        {
            if(chatId.ToString() == "00000000-0000-0000-0000-000000000000"){
                chatId = Guid.Parse(HttpContext.Session.GetString("ChatId"));
            }

            string uri = $"{baseuri}/chats/{chatId}";
            Chat currentChat = WebApiHelper.GetApiResult<Chat>(uri);

            uri = $"{baseuri}/messages/chatId/{chatId}";
            List<Message> messagesFromChat = WebApiHelper.GetApiResult<List<Message>>(uri);
            currentChat.Messages = messagesFromChat;//de messages moeten apart opgehaald worden door de [JsonIgnore] in Chat class

            Guid myId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            User currentUser = await GetUserWithId(myId);

            OpenExistingChatVM vm = new OpenExistingChatVM
            {
                Chat = currentChat,
                Me = currentUser
            };

            return View(vm);
        }
    }
}