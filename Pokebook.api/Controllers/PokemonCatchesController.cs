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
            _dbc = dbc;
            _m = m;
        }
        
        private IHostingEnvironment _hostingEnvironment;
        private PokebookContext _dbc;
        private IMapper _m;

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
            List<PokemonMoveCatch> pokemonMoveCatches = new List<PokemonMoveCatch>();

            foreach(var pokemonCatch in pokemonCatches)
            {
                List<PokemonMoveCatch> foundMoveCatches = await unitOfWork.PokemonMoveCatches.GetAllByPokemonCatchId(pokemonCatch.Id);
                pokemonMoveCatches.AddRange(foundMoveCatches);
            }

            PokemonCatchSyncDTO syncDTO = new PokemonCatchSyncDTO
            {
                UserId = pokemon.UserId,
                PokemonCatches = pokemonCatches,
                PokemonMoveCatches = pokemonMoveCatches
            };

            return Ok(syncDTO);
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
            await Task.Delay(0);
            try
            {
                foreach (var poke in pokemon.PokemonCatches) AddPokemonCatch(poke);//moet gerefactored worden
                //foreach (var move in pokemon.PokemonMoveCatches) unitOfWork.PokemonMoveCatches.AddPokemonMoveCatch(move);//alternatief op aanspreken van andere controller

                var moveCatchesController = new PokemonMoveCatchesController(_dbc, _m, new PokemonMoveCatchRepository(_dbc, _m), _hostingEnvironment);
                foreach (var move in pokemon.PokemonMoveCatches) moveCatchesController.Add(move);
                return Ok(Guid.Parse("00000000-0000-0000-0000-000000000001"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete]
        [Route("Delete/{id}/{save}")]
        public async Task<IActionResult> DeletePokemonCatch(Guid id, bool save)
        {
            await Task.Delay(0);
            try
            {
                PokemonCatch toDelete = unitOfWork.PokemonCatches.FindById(id);
                if (toDelete != null)
                {
                    if (save)
                    {
                        unitOfWork.PokemonCatchDeleted.AddPokemonCatchDeleted(toDelete);
                        PokemonCatchDeleted deleted = unitOfWork.PokemonCatchDeleted.FindById(id);
                        if (deleted != null) unitOfWork.PokemonCatches.DeletePokemonCatch(toDelete);
                        return Ok(deleted.Id);
                    }
                    else {
                        List<PokemonMoveCatch> pokemonMoveCatches = await unitOfWork.PokemonMoveCatches.GetAllByPokemonCatchId(id);
                        unitOfWork.PokemonCatches.DeletePokemonCatch(toDelete);
                        unitOfWork.PokemonMoveCatches.DeleteRangePokemonMoveCatches(pokemonMoveCatches);
                    }
                }
                return Ok(new PokemonCatchSyncDTO());//de mobile app verwacht dit terug
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("DeleteRange")]
        public async Task<IActionResult> DeletePokemonCatchRange([FromBody]GuidSyncDTO toDelete)
        {//de save parameter wordt niet meegegeven
            foreach (Guid id in toDelete.PokemonCatches) await DeletePokemonCatch(id, false);//hier worden ook de moveCatches verwijderd
            return Ok(new List<PokemonCatch>());//de DelCallAPI function in Xamarin verwacht een List van PokemonCatches
        }

        [HttpPost]
        [Route("GetPokemonCatchesWithProperty")]
        public async Task<IActionResult> GetPokemonCatchesWithProperty(SearchObject obj)
        {
            return Ok(await unitOfWork.PokemonCatches.GetPokemonCatchesWithProperty(obj));
        }
    }
}