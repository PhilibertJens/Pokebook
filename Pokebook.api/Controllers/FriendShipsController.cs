using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using Pokebook.core.Repositories.Specific;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendShipsController : ControllerCrudBase<Friendship>
    {
        public FriendShipsController(PokebookContext dbc, IMapper m, FriendshipRepository repo) : base(dbc, m, repo)
        {
        }

        [HttpGet]
        [Route("GetFriendship/{userid}/{friendid}")]
        public IActionResult GetFriendship(Guid userid, Guid friendid)
        {
            return Ok(unitOfWork.Friendships.GetFriendship(userid, friendid));
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Friendship friendship)
        {
            return Ok(Post(friendship));
        }
    }
}