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

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonMoveCatchesController : ControllerCrudBase<PokemonMoveCatch>
    {
        public PokemonMoveCatchesController(PokebookContext dbc, IMapper m, PokemonMoveCatchRepository repo, IHostingEnvironment hostingEnvironment) : base(dbc, m, repo)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private IHostingEnvironment _hostingEnvironment;

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(PokemonMoveCatch moveCatch)
        {
            moveCatch.Move = null;
            moveCatch.Pokemon = null;
            //Guid id = unitOfWork.PokemonMoveCatches.AddPokemonMoveCatch(moveCatch);--> kan ook gebruikt worden
            return Ok(Post(moveCatch));
        }
    }
}