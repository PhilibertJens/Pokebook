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
        public IActionResult GetChat(Guid Id)
        {
            return Ok(repository.GetById(Id));
        }
    }
}