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
    public class PokemonTypesController : ControllerCrudBase<PokemonType>
    {
        public PokemonTypesController(PokebookContext dbc, IMapper m, PokemonTypeRepository repo, IHostingEnvironment hostingEnvironment) : base(dbc, m, repo)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private IHostingEnvironment _hostingEnvironment;

        [HttpGet]
        [Route("GetByTypeName/{typeName}")]
        public async Task<IActionResult> GetPokemonTypeListByTypeNameAsync(string typeName)
        {
            var test = await unitOfWork.PokemonTypes.GetPokemonListByTypeName(typeName);
            return Ok(test);
        }
    }
}