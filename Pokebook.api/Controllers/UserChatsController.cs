using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using Pokebook.core.Repositories;
using Pokebook.core.Repositories.Specific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserChatsController : ControllerCrudBase<UserChat>
    {
        public UserChatsController(PokebookContext dbc, IMapper m, UserChatRepository repo) :
            base(dbc, m,repo)
        {
        }

        //GET: api/UserChats/UserId/Id
        [HttpGet]
        [Route("UserId/{Id}")]
        public IActionResult GetUserChatsForUser(Guid Id)
        {
            return Ok(unitOfWork.UserChats.GetUserChatsForUser(Id));
        }

        //GET: api/UserChats/ChatId/Id
        [HttpGet]
        [Route("ChatId/{Id}")]
        public IActionResult GetUserChatsForChat(Guid Id)
        {
            return Ok(unitOfWork.UserChats.GetUserChatsForChat(Id));
        }

        [HttpPost]
        [Route("AddUsersToChat")]
        public async Task<IActionResult> AddUsersToChat(AddUserToChatDTO addUserToChat)
        {
            Chat currentChat = unitOfWork.Chats.FindById(addUserToChat.ChatId);
            List<UserSimpleDTO> users = await unitOfWork.Users.GetChatUsersSimple(currentChat.Id);
            foreach(var test in users)
            {//controle als er geen bestaande user wordt toegevoegd
                if (addUserToChat.Users.Contains(test.UserName)) addUserToChat.Users.Remove(test.UserName);
            }

            List<UserChat> userChats = new List<UserChat>();
            foreach(var uc in addUserToChat.Users)
            {
                User user = await unitOfWork.Users.FindUserByUserName(uc);
                if(user != null)
                {
                    UserChat newUserChat = new UserChat
                    {
                        ChatId = addUserToChat.ChatId,
                        UserId = user.Id
                    };
                    userChats.Add(newUserChat);
                }
            }
            var addedUsers = unitOfWork.UserChats.AddRange(userChats);
            if (addedUsers.Count() > 0)
            {
                currentChat.NumberOfUsers += addedUsers.Count();
                unitOfWork.Chats.Update(currentChat);
            }
            unitOfWork.Complete();
            return Ok(addedUsers);
        }
    }
}