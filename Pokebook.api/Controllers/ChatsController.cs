using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;
using Pokebook.core.Repositories;
using Pokebook.core.Repositories.Specific;
using System;
using System.Threading.Tasks;
using AutoMapper;
using Pokebook.core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Newtonsoft.Json;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatsController : ControllerCrudBase<Chat>
    {
        public ChatsController(PokebookContext dbc, IMapper m, ChatRepository repo, IHostingEnvironment hostingEnvironment) : base(dbc, m,repo)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private IHostingEnvironment _hostingEnvironment;

        // GET: api/Chats
        [HttpGet]
        public override IActionResult Get()
        {
            return Ok(unitOfWork.Chats.ListAll());//later enkel voor admin gebruikers!
        }

        // GET: api/Chats/UserId/Id
        [HttpGet]
        [Route("UserId/{Id}")]
        public IActionResult GetChatsForUser(Guid id)
        {
            return Ok(unitOfWork.Chats.FindChatsForUser(id));
        }

        // GET: api/Chats/Username/Username
        [HttpGet]
        [Route("Username/{userName}")]
        public IActionResult GetChatsForUser(string userName)
        {
            return Ok(unitOfWork.Chats.FindChatsForUser(userName));
        }

        //GET: api/Chats/simple
        [HttpGet]
        [Route("Simple")]
        public IActionResult GetSimpleChats()
        {
            return Ok(unitOfWork.Chats.GetChatSimples());
        }

        [HttpPut]
        [Route("Addition/{chatId}")]
        public IActionResult UpdateNumberOfMessages(Guid chatId)
        {
            Chat chat = unitOfWork.Chats.FindById(chatId);
            chat.NumberOfMessages++;
            unitOfWork.Chats.Update(chat);
            unitOfWork.Complete();
            return Ok(chat);
        }

        [HttpPost]
        [Route("Uploads/ChatImage/{chatName}")]
        [Consumes("application/json", "multipart/form-data")]
        public async Task<IActionResult> UploadChatImage([FromForm(Name = "file")] IFormFile formFile, string chatName)
        {
            string uniqueFileName = Guid.NewGuid().ToString("N") + formFile.FileName;
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images/ChatPictures", uniqueFileName);
            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }
            return Ok(JsonConvert.SerializeObject(uniqueFileName));
        }
    }
}