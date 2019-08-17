using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;
using Pokebook.core.Repositories.Specific;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesController : ControllerCrudBase<core.Models.Type>
    {
        public TypesController(PokebookContext dbc, IMapper m, TypeRepository repo, IHostingEnvironment hostingEnvironment) : base(dbc, m, repo)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private IHostingEnvironment _hostingEnvironment;

        [HttpGet]
        public override IActionResult Get()
        {
            return Ok(unitOfWork.Types.ListAll());
        }

        // GET: api/Types/Id
        [HttpGet]
        [Route("/{Id}")]
        public IActionResult GetTypeById(Guid Id)
        {
            return Ok(unitOfWork.Types.FindById(Id));
        }

        // GET: api/Types/typeName/typeName
        [HttpGet]
        [Route("typeName/{typeName}")]
        public async Task<IActionResult> GetTypeByName(string typeName)
        {
            return Ok(await unitOfWork.Types.FindTypeByTypeNameAsync(typeName));
        }
    }
}