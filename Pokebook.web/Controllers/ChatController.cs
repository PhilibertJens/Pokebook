﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
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
        public ChatController()
        {
            Constants constants = new Constants();
            baseuri = $"{constants.ApiServerSideAddress}/api";
        }
        readonly string baseuri;

        public Guid? CheckSession()
        {
            string id = HttpContext.Session.GetString("UserId");
            if (id != null) return Guid.Parse(id);
            else return null;
        }

        public async Task<IActionResult> Index()
        {
            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;
            string uri = $"{baseuri}/chats/userId/{userId}";
            List<Chat> chatListForUser = await WebApiHelper.GetApiResult<List<Chat>>(uri);

            UserSimpleDTO currentUser = await GetUserWithId(userId);

            var allUsers = await FilterUserList(userId);

            ChatIndexVM vm = new ChatIndexVM
            {
                User = currentUser,
                AllUsers = new SelectList(allUsers, "Id", "UserName")
            };
            //HttpContext.Session.SetString("chatId", "9bc5f401-9684-48a9-2ffe-08d6bd9fc1a1");
            //return new RedirectToActionResult("OpenExistingChat", "Chat", null);
            return View(vm);
        }

        public async Task<UserSimpleDTO> GetUserWithId(Guid userId)
        {
            string uri = $"{baseuri}/users/{userId}";
            return await WebApiHelper.GetApiResult<UserSimpleDTO>(uri);
        }

        private async Task<List<UserSimpleDTO>> FilterUserList(Guid userId)
        {
            string uri = $"{baseuri}/users/NewChatUsers/{userId}";
            List<UserSimpleDTO> usersToStartChatWith = await WebApiHelper.GetApiResult<List<UserSimpleDTO>>(uri);
            return usersToStartChatWith;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ChatIndexVM userdata)
        {
            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;

            HttpContext.Session.SetString("ReceiverId", userdata.SelectedUserId.ToString());
            return new RedirectToActionResult("SendFirstMessage", "Chat", null);
        }

        public async Task<IActionResult> SendFirstMessage()
        {
            Guid senderId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else senderId = (Guid)tempUserId;

            UserSimpleDTO sender = await GetUserWithId(senderId);

            Guid receiverId = Guid.Parse(HttpContext.Session.GetString("ReceiverId"));
            UserSimpleDTO receiver = await GetUserWithId(receiverId);

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
            Guid senderId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else senderId = (Guid)tempUserId;

            UserSimpleDTO sender = await GetUserWithId(senderId);

            Guid receiverId = Guid.Parse(HttpContext.Session.GetString("ReceiverId"));
            UserSimpleDTO receiver = await GetUserWithId(receiverId);

            if (ModelState.IsValid)
            {
                Chat chat = new Chat
                {
                    Name = $"{sender.UserName}, {receiver.UserName}",
                    CreatorId = senderId,
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
                    UserId = receiverId
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
            Guid myId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else myId = (Guid)tempUserId;

            if (chatId.ToString() == "00000000-0000-0000-0000-000000000000"){
                chatId = Guid.Parse(HttpContext.Session.GetString("ChatId"));
            }

            //string uri = $"{baseuri}/chats/{chatId}";
            string uri = $"{baseuri}/chats/GetChatSafe/{chatId}/{myId}";//extra controle als je wel lid bent van deze chat
            Chat currentChat = await WebApiHelper.GetApiResult<Chat>(uri);
            if(currentChat != null)
            {
                uri = $"{baseuri}/messages/range/{chatId}/{0}/{20}";//--> enkel de 20 recentste berichten worden getoond
                List<Message> messagesFromChat = await WebApiHelper.GetApiResult<List<Message>>(uri);
                currentChat.Messages = messagesFromChat;//de messages moeten apart opgehaald worden door de [JsonIgnore] in Chat class

                UserSimpleDTO currentUser = await GetUserWithId(myId);

                OpenExistingChatVM vm = new OpenExistingChatVM
                {
                    Chat = currentChat,
                    Me = currentUser,
                    Id = myId
                };
                return View(vm);
            }
            return new RedirectToActionResult("Index", "Home", null);
        }
        
        public async Task<IActionResult> LeaveChat(Guid chatId)
        {
            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;

            string uri = $"{baseuri}/UserChats/DeleteUserFromChat/{chatId}/{userId}";
            var result = await WebApiHelper.DelCallAPI<Guid>(uri);
            return new RedirectToActionResult("Index", "Home", null);
        }
    }
}