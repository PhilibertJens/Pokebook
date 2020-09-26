using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Repositories.Specific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonCatchDeletedController : ControllerCrudBase<PokemonCatchDeleted>
    {
        public PokemonCatchDeletedController(PokebookContext dbc, IMapper m, PokemonCatchDeletedRepository repo) : base(dbc, m, repo)
        {
            
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public override IActionResult Get(Guid id)
        {
            return Ok(unitOfWork.PokemonCatchDeleted.FindById(id));
        }

        [HttpGet]
        [Route("GetMyPokemonCatchDeletedWithPoke/{userId}")]
        public async Task<IActionResult> GetMyPokemonCatchDeleted(Guid userId)
        {
            var myDeletedPokemon = await unitOfWork.PokemonCatchDeleted.GetAllPokemonCatchDeleted(userId);
            foreach (var pokemon in myDeletedPokemon)
            {
                Guid pokemonId = pokemon.PokemonId;
                pokemon.Pokemon = await unitOfWork.Pokemons.GetWithType(pokemon.PokemonId);//GetAllCaughtPokemonFull kan niet gebruikt worden
            }
            return Ok(myDeletedPokemon);
        }

        [HttpGet]
        [Route("GetMyPokemonCatchDeleted/{userId}")]
        public async Task<IActionResult> GetMyPokemonCaches(Guid userId)
        {
            var myDeletedPokemon = await unitOfWork.PokemonCatchDeleted.GetAllPokemonCatchDeleted(userId);
            return Ok(myDeletedPokemon);
        }

        [HttpGet]
        [Route("GetMyPokemonCatchDeletedGuids/{userId}")]
        public async Task<IActionResult> GetMyPokemonCatchDeletedGuids(Guid userId)
        {
            List<Guid> allGuids = await unitOfWork.PokemonCatchDeleted.GetAllGuids(userId);
            return Ok(allGuids);
        }

        //[HttpPost] --> Dit gebeurt nooit rechtstreeks, enkel na het verwijderen van een pokemonCatch
        //[Route("Add")]
        //public async Task<IActionResult> AddPokemonCatchDeleted(PokemonCatch toDelete)
        //{

        //}

    }
}
