using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;
using Pokebook.core.Repositories;
using Pokebook.core.Repositories.Specific;
using System;
using System.Threading.Tasks;
using AutoMapper;
using Pokebook.core.Models;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatsController : ControllerCrudBase<Chat>
    {
        public ChatsController(PokebookContext dbc, IMapper m, ChatRepository repo) : base(dbc, m,repo)
        {
        }

        // GET: api/Chats
        [HttpGet]
        public override IActionResult Get()
        {
            return Ok(unitOfWork.Chats.ListAll());//later enkel voor admin gebruikers!
        }

        // GET: api/Chats/UserId/Id
        [HttpGet]
        [Route("UserId/{Id}")]
        public IActionResult GetChatsForUser(Guid id)
        {
            return Ok(unitOfWork.Chats.FindChatsForUser(id));
        }

        // GET: api/Chats/Username/Username
        [HttpGet]
        [Route("Username/{userName}")]
        public IActionResult GetChatsForUser(string userName)
        {
            return Ok(unitOfWork.Chats.FindChatsForUser(userName));
        }

        //GET: api/Chats/simple
        [HttpGet]
        [Route("Simple")]
        public IActionResult GetSimpleChats()
        {
            return Ok(unitOfWork.Chats.GetChatSimples());
        }

        [HttpPut]
        [Route("Addition/{chatId}")]
        public IActionResult UpdateNumberOfMessages(Guid chatId)
        {
            Chat chat = unitOfWork.Chats.FindById(chatId);
            chat.NumberOfMessages++;
            unitOfWork.Chats.Update(chat);
            unitOfWork.Complete();
            return Ok();
        }
    }
}