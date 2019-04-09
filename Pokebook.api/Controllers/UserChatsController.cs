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
    public class UserChatsController : ControllerCrudBase<UserChat>
    {
        public UserChatsController(PokebookContext dbc, IMapper m, UserChatRepository repo) :
            base(dbc, m,repo)
        {
        }

        //GET: api/UserChats/Id/Id
        [HttpGet]
        [Route("Id/{Id}")]
        public IActionResult GetUserChatsForUser(Guid Id)
        {
            return Ok(unitOfWork.UserChats.GetUserChatsForUser(Id));
        }
    }
}