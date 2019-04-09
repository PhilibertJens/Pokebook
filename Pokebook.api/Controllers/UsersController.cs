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
        [Route("")]
        public override IActionResult Get()
        {
            return Ok(unitOfWork.Users.ListAll());
        }

        // GET: api/Users/Id
        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetUserWithId(Guid Id)
        {
            return Ok(unitOfWork.Users.FindById(Id));
        }

        // GET: api/Users/userName/userName
        [HttpGet]
        [Route("userName/{userName}")]
        public IActionResult GetUserWithUserName(string userName)
        {
            return Ok(unitOfWork.Users.FindUserByUserName(userName));
        }
    }
}