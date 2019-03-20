using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.api.Repositories;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatsController : ControllerBase
    {
        ChatRepository repository;
        public ChatsController(ChatRepository chatRepository)
        {
            repository = chatRepository;
        }

        // GET: api/Chats
        [HttpGet]
        public async Task<IActionResult> GetChats()
        {
            return Ok(await repository.ListAll());//later enkel voor admin gebruikers!
        }

        // GET: api/Chats/Id
        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetChat(Guid Id)
        {
            return Ok(await repository.GetById(Id));
        }

        // GET: api/Chats/UserId/Id
        [HttpGet]
        [Route("UserId/{Id}")]
        public async Task<IActionResult> GetChatsForUser(Guid Id)
        {
            return Ok(await repository.GetChatsForUser(Id));
        }

        // GET: api/Chats/Username/Username
        [HttpGet]
        [Route("Username/{userName}")]
        public async Task<IActionResult> GetChatsForUser(string userName)
        {
            return Ok(await repository.GetChatsForUser(userName));
        }
    }
}