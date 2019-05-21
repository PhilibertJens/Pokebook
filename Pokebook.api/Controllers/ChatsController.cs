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
using Pokebook.core.Models.DTO;

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
        [Route("ChatSettings")]
        [Consumes("application/json", "multipart/form-data")]
        public IActionResult UpdateChatSettings(ChatSettingsDTO chatSettings)
        {
            Chat foundChat = unitOfWork.Chats.FindById(chatSettings.ChatId);
            if(foundChat != null)
            {
                foundChat.Name = chatSettings.ChatName;
                foundChat.Image = chatSettings.ChatImage;
            }
            return Ok(Put(foundChat.Id, foundChat));// als er geen update is gebeurd komt er een Microsoft.AspNetCore.Mvc.NotFoundResult (statusCode 404) result
        }

        [HttpPost]
        [Route("Uploads/ChatImage")]
        [Consumes("application/json", "multipart/form-data")]
        public async Task<IActionResult> UploadChatImage([FromForm(Name = "file")] IFormFile formFile)
        {
            if(formFile != null)
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
            return BadRequest();
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(Guid Id)
        {
            return Ok(unitOfWork.Chats.FindById(Id));
        }

        // GET: api/Users/CoverPicture/name
        [HttpGet]
        [Route("ChatPicture/{filename}")]
        public IActionResult ChatPicture(string filename)
        {
            var image = Path.Combine(_hostingEnvironment.WebRootPath, "images/ChatPictures", filename);
            return PhysicalFile(image, "image/jpeg");
        }
    }
}