﻿using System;
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

        [HttpGet]
        [Route("GetById/{pokemonId}/{userId}")]
        public IActionResult GetPokemonUserById(Guid pokemonId, Guid userId)
        {
            return Ok(unitOfWork.PokemonUsers.GetPokemonUserById(pokemonId, userId));
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddPokemonUser(PokemonUser pokemonUser)
        {
            return Ok(Post(pokemonUser));
        }

        [HttpPut]
        [Route("UpdateAdd")]
        public IActionResult Update(PokemonUser pokemonUser)
        {
            pokemonUser.Catches++;
            unitOfWork.PokemonUsers.Update(pokemonUser);
            unitOfWork.Complete();
            return Ok(pokemonUser);
        }
    }
}