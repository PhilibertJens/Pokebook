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

    }
}
