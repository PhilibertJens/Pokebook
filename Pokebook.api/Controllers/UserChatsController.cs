using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using Pokebook.core.Repositories;
using Pokebook.core.Repositories.Specific;
using System;
using System.Collections.Generic;

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
        public IActionResult AddUsersToChat(AddUserToChatDTO addUserToChat)
        {
            List<UserChat> userChats = new List<UserChat>();
            foreach(var uc in addUserToChat.Users)
            {
                User user = unitOfWork.Users.FindUserByUserName(uc);
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
            var test = unitOfWork.UserChats.AddRange(userChats);
            unitOfWork.Complete();
            return Ok(test);
        }
    }
}