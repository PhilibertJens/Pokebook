using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Repositories.Specific;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerCrudBase<User>
    {
        public UsersController(PokebookContext dbc, IMapper m, UserRepository repo) : base(dbc, m, repo)
        {
        }

        // GET: api/Users
        [HttpGet]
        [Route("Users/")]
        public override IActionResult Get()
        {
            return Ok(unitOfWork.Users.ListAll());
        }

        // GET: api/Users
        [HttpGet]
        public IActionResult GetUserWithId(Guid Id)
        {
            return Ok(unitOfWork.Users.FindById(Id));
        }

        // GET: api/Users/userName
        [HttpGet]
        [Route("Users/{userName}")]
        public IActionResult GetUserWithUserName(string userName)
        {
            return Ok(unitOfWork.Users);
        }

        // GET: api/Chats/Username/Username
        [HttpGet]
        [Route("Username/{userName}")]
        public IActionResult GetChatsForUser(string userName)
        {
            return Ok(unitOfWork.Chats.FindChatsForUser(userName));
        }
    }
}