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

        // GET: api/PokemonCatches/GetMyPokemon/userId
        [HttpGet]
        [Route("GetMyPokemon/{userId}")]
        public async Task<IActionResult> GetMyPokemon(Guid userId)
        {
            var myPokemon = await unitOfWork.PokemonCatches.GetAllCaughtPokemon(userId);
            return Ok(myPokemon);
        }

        // GET: api/PokemonCatches/CreateFromTemplate/name/userId
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
            //pokemon.User = null;
            return Ok(Post(pokemon));
        }
    }
}