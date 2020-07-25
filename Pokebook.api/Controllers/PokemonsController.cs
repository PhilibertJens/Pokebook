using System;
using System.Collections.Generic;
using System.IO;
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
    public class PokemonsController : ControllerCrudBase<Pokemon>
    {
        public PokemonsController(PokebookContext dbc, IMapper m, PokemonRepository repo, IHostingEnvironment hostingEnvironment) : base(dbc, m, repo)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private IHostingEnvironment _hostingEnvironment;

        // GET: api/Pokemons/GetAll
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var list = await unitOfWork.Pokemons.GetAllWithType();
            return Ok(list);
        }

        // GET: api/Pokemons/GetAllNames
        [HttpGet]
        [Route("GetAllNames")]
        public async Task<IActionResult> GetAllNames()
        {
            var list = await unitOfWork.Pokemons.GetAllNames();
            return Ok(list);
        }

        // GET: api/Pokemons/id
        [HttpGet]
        [Route("GetById/{id}")]
        public override IActionResult Get(Guid id)
        {
            return Ok(unitOfWork.Pokemons.FindById(id));
        }

        // GET: api/Pokemons/name
        [HttpGet]
        [Route("name/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var pokemon = await unitOfWork.Pokemons.GetByName(name);
            return Ok(pokemon);
        }

        [HttpGet]
        [Route("GetByNdex/{ndex}")]
        public async Task<IActionResult> GetByNdex(int ndex)
        {
            var pokemon = await unitOfWork.Pokemons.GetByNdex(ndex);
            return Ok(pokemon);
        }

        [HttpGet]
        [Route("GetFullPokemon/{id}")]
        public async Task<IActionResult> GetFullPokemon(Guid id)
        {
            return Ok(await unitOfWork.Pokemons.GetFullPokemon(id));
        }

        [HttpGet]
        [Route("GetFullPokemonByName/{name}")]
        public async Task<IActionResult> GetFullPokemon(string name)
        {
            PokemonSimpleDTO pokemonSimple = await unitOfWork.Pokemons.GetPokemonSimple(name);
            return Ok(await unitOfWork.Pokemons.GetFullPokemon(pokemonSimple.Id));
        }

        // GET: api/Users/CoverPicture/name
        [HttpGet]
        [Route("PokemonPicture/{filename}/{type}")]
        public IActionResult PokemonPicture(string filename, string type)
        {
            string extension = filename.Substring(filename.Length - 3);
            if (!extension.Equals("png")) filename+=".png";

            var image = Path.Combine(_hostingEnvironment.WebRootPath, $"images/PokemonPictures/{type}", filename);
            if (!System.IO.File.Exists(image)) image = Path.Combine(_hostingEnvironment.WebRootPath, $"images/GeneralPictures/", "notFound.png");
            return PhysicalFile(image, "image/jpeg");
        }
    }
}