using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Repositories.Specific;
using Type = Pokebook.core.Models.Type;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovesController : ControllerCrudBase<Move>
    {
        public MovesController(PokebookContext dbc, IMapper m, MoveRepository repo, IHostingEnvironment hostingEnvironment) : base(dbc, m, repo)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private IHostingEnvironment _hostingEnvironment;

        [HttpGet]
        public override IActionResult Get()
        {
            return Ok(unitOfWork.Moves.ListAll());
        }

        [HttpGet]
        [Route("GetByType/{typeId}")]
        public async Task<IActionResult> GetByType(Guid typeId)
        {
            return Ok(await unitOfWork.Moves.GetByType(typeId));
        }
    }
}