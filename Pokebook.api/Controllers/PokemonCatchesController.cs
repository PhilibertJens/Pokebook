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
    public class PokemonCatchesController : ControllerCrudBase<PokemonCatch>
    {
        public PokemonCatchesController(PokebookContext dbc, IMapper m, PokemonCatchRepository repo, IHostingEnvironment hostingEnvironment) : base(dbc, m, repo)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private IHostingEnvironment _hostingEnvironment;

        // GET: api/PokemonCatches
        [HttpGet]
        public override IActionResult Get(Guid id)
        {
            return Ok(unitOfWork.Pokemons.FindById(id));
        }

        // GET: api/PokemonCatches/name
        [HttpGet]
        [Route("CreateFromTemplate/{name}/{userId}")]
        public async Task<IActionResult> CreateFromTemplate(string name, Guid userId)
        {
            Pokemon template = await unitOfWork.Pokemons.GetByName(name);
            var createdPokemon = unitOfWork.PokemonCatches.CreateFromTemplate(template, userId);
            return Ok(createdPokemon);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddPokemonCatch(PokemonCatch pokemon)
        {
            pokemon.Pokemon = null;//als dit niet gebeurt verschijnt er een duplicated insert error bij de Pokemons tabel
            return Ok(Post(pokemon));
        }
    }
}