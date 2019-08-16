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
    public class PokemonsController : ControllerCrudBase<Pokemon>
    {
        public PokemonsController(PokebookContext dbc, IMapper m, PokemonRepository repo, IHostingEnvironment hostingEnvironment) : base(dbc, m, repo)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private IHostingEnvironment _hostingEnvironment;


        // GET: api/Pokemons
        [HttpGet]
        public override IActionResult Get(Guid id)
        {
            return Ok(unitOfWork.Pokemons.FindById(id));
        }

        // GET: api/Pokemons/name
        [HttpGet]
        [Route("name/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var test = await unitOfWork.Pokemons.GetByName(name);
            return Ok(test);
        }
    }
}