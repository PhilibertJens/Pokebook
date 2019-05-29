using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Repositories;
using Pokebook.core.Repositories.Specific;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerCrudBase<Message>
    {
        public MessagesController(PokebookContext dbc, IMapper m, MessageRepository repo, IHostingEnvironment hostingEnvironment) :
            base(dbc,m,repo)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private IHostingEnvironment _hostingEnvironment;

        //api/Messages
        [HttpGet]
        public override IActionResult Get()
        {
            return Ok(unitOfWork.Messages.ListAll());
        }

        //GET: api/Messages/chatId/id
        [HttpGet]
        [Route("chatId/{chatId}")]
        public IActionResult GetByChatId(Guid chatId)
        {
            return Ok(unitOfWork.Messages.GetByChatId(chatId));
        }

        [HttpGet]
        [Route("range/{chatId}/{startMessage}/{numberOfMessages}")]
        public IActionResult GetMessageRange(Guid chatId, int startMessage, int numberOfMessages)
        {
            return Ok(unitOfWork.Messages.GetMessageRange(chatId, startMessage, numberOfMessages));
        }

        [HttpPost]
        [Route("MessagePicture")]
        [Consumes("application/json", "multipart/form-data")]
        public async Task<IActionResult> UploadMessageImage([FromForm(Name = "file")] IFormFile formFile)
        {
            if (formFile != null)
            {
                string uniqueFileName = Guid.NewGuid().ToString("N") + formFile.FileName;
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images/MessagePictures", uniqueFileName);
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
                return Ok(JsonConvert.SerializeObject(uniqueFileName));
            }
            return Ok("");
        }
    }
}