using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Repositories;
using Pokebook.core.Repositories.Specific;
using System;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerCrudBase<Message>
    {
        public MessagesController(PokebookContext dbc, IMapper m, MessageRepository repo) :
            base(dbc,m,repo)
        {
        }

        //api/Messages
        [HttpGet]
        public override IActionResult Get()
        {
            return Ok(unitOfWork.Messages.ListAll());
        }

        //GET: api/Messages/chatId/id
        [HttpGet]
        [Route("chatId/{chatId}")]
        public IActionResult GetByChatId(Guid chatId)
        {
            return Ok(unitOfWork.Messages.GetByChatId(chatId));
        }
    }
}