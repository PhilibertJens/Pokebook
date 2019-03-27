using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.api.Models;
using Pokebook.api.Repositories;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerCrudBase<Message, MessageRepository>
    {
        public MessagesController(MessageRepository messageRepository):
            base(messageRepository)
        {
        }
    }
}