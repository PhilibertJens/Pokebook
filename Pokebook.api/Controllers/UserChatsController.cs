using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserChatsController : ControllerCrudBase
    {
        public UserChatsController(PokebookContext dbc, IMapper m) :
            base(dbc, m)
        {
        }
    }
}