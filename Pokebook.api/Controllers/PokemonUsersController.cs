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
    public class PokemonUsersController : ControllerCrudBase<PokemonUser>
    {
        public PokemonUsersController(PokebookContext dbc, IMapper m, PokemonUserRepository repo, IHostingEnvironment hostingEnvironment) : base(dbc, m, repo)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private IHostingEnvironment _hostingEnvironment;

        [HttpPost]
        [Route("add")]
        public IActionResult AddPokemonUser(PokemonUser pokemonUser)
        {
            return Ok(Post(pokemonUser));
        }
    }
}