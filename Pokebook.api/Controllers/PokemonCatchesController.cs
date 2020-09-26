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
using Pokebook.core.Models.DTO;
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
                pokemon.Pokemon = await unitOfWork.Pokemons.GetWithType(pokemon.PokemonId);//GetAllCaughtPokemonFull kan niet gebruikt worden
            }
            return Ok(myCaughtPokemon);
        }

        [HttpGet]
        [Route("GetMyPokemonCatches/{userId}")]
        public async Task<IActionResult> GetMyPokemonCaches(Guid userId)
        {
            var myCaughtPokemon = await unitOfWork.PokemonCatches.GetAllCaughtPokemon(userId);
            return Ok(myCaughtPokemon);
        }

        [HttpGet]
        [Route("GetMyPokemonCatchGuids/{userId}")]
        public async Task<IActionResult> GetMyPokemonCatchGuids(Guid userId)
        {
            List<Guid> allGuids = await unitOfWork.PokemonCatches.GetAllGuids(userId);
            return Ok(allGuids);
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
        [Route("GetAllByGuidRange")]
        public async Task<IActionResult> GetAllPokemonCatchesByGuidRange([FromBody]GuidSyncDTO pokemon)
        {
            List<PokemonCatch> pokemonCatches = await unitOfWork.PokemonCatches.GetAllByGuidRange(pokemon.PokemonCatches);
            return Ok(pokemonCatches);
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

        [HttpPost]
        [Route("AddRange")]
        public async Task<IActionResult> AddRangePokemonCatches([FromBody]PokemonCatchSyncDTO pokemon)
        {
            try
            {
                // do whatever you want to do with the yourDto object
                return Ok(Guid.Parse("00000000-0000-0000-0000-000000000001"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> DeletePokemonCatch(Guid id)
        {
            PokemonCatch toDelete = unitOfWork.PokemonCatches.FindById(id);
            unitOfWork.PokemonCatchDeleted.AddPokemonCatchDeleted(toDelete);

            PokemonCatchDeleted deleted = unitOfWork.PokemonCatchDeleted.FindById(id);
            if (deleted != null) unitOfWork.PokemonCatches.DeletePokemonCatch(toDelete);
            return Ok(deleted.Id);
        }

        [HttpPost]
        [Route("GetPokemonCatchesWithProperty")]
        public async Task<IActionResult> GetPokemonCatchesWithProperty(SearchObject obj)
        {
            return Ok(await unitOfWork.PokemonCatches.GetPokemonCatchesWithProperty(obj));
        }
    }
}