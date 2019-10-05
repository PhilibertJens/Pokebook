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
            var myCaughtPokemon = await unitOfWork.PokemonCatches.GetAllCaughtPokemon(userId);
            foreach (var pokemon in myCaughtPokemon)
            {
                Guid pokemonId = pokemon.PokemonId;
                pokemon.Pokemon = await unitOfWork.Pokemons.GetWithType(pokemon.PokemonId);
            }
            return Ok(myCaughtPokemon);
        }

        // GET: api/PokemonCatches/CreateFromTemplate/pokemonId/userId
        [HttpGet]
        [Route("CreateFromTemplate/{pokemonId}/{userId}")]
        public async Task<IActionResult> CreateFromTemplate(Guid pokemonId, Guid userId)
        {
            Pokemon template = await unitOfWork.Pokemons.GetFullPokemon(pokemonId);
            var createdPokemon = unitOfWork.PokemonCatches.CreateFromTemplate(template, userId);
            return Ok(createdPokemon);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddPokemonCatch(PokemonCatch pokemon)
        {
            pokemon.Pokemon = null;//als dit niet gebeurt verschijnt er een duplicated insert error bij de Pokemons tabel
            pokemon.User = null;
            pokemon.PokemonMoveCatches = null;
            Guid id = unitOfWork.PokemonCatches.AddPokemonCatch(pokemon);
            //return Ok(Post(pokemon)); --> returned een empty PokemonCatch, we hebben de id echter nodig
            return Ok(id);
        }
    }
}