﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
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
    public class UsersController : ControllerCrudBase<User>
    {
        private IHostingEnvironment _hostingEnvironment;

        public UsersController(PokebookContext dbc, IMapper m, UserRepository repo, IHostingEnvironment hostingEnvironment) 
            : base(dbc, m, repo)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: api/Users
        [HttpGet]
        [Route("")]
        public override IActionResult Get()
        {
            return Ok(unitOfWork.Users.ListAll());
        }

        // GET: api/Users/Id
        [HttpGet]
        [Route("/{Id}")]
        public IActionResult GetUserWithId(Guid Id)
        {
            return Ok(unitOfWork.Users.FindById(Id));
        }

        // GET: api/Users/userName/userName
        [HttpGet]
        [Route("userName/{userName}")]
        public async Task<IActionResult> GetUserWithUserName(string userName)
        {
            return Ok(await unitOfWork.Users.FindUserByUserName(userName));
        }

        // GET: api/Users/ProfilePicture/name
        [HttpGet]
        [Route("ProfilePicture/{filename}")]
        public IActionResult ProfilePicture(string filename)
        {
            var image = Path.Combine(_hostingEnvironment.WebRootPath, "images/ProfilePictures", filename);
            return PhysicalFile(image, "image/png");
        }

        // GET: api/Users/CoverPicture/name
        [HttpGet]
        [Route("CoverPicture/{filename}")]
        public IActionResult CoverPicture(string filename)
        {
            var image = Path.Combine(_hostingEnvironment.WebRootPath, "images/CoverPictures", filename);
            return PhysicalFile(image, "image/jpeg");
        }

        // POST: api/Users/ProfilePicture/
        [HttpPost]
        [Route("ProfilePicture")]
        public async Task<IActionResult> ProfilePicture([FromForm(Name = "file")] IFormFile formFile)
        {
            string uniqueFileName = Guid.NewGuid().ToString("N") + formFile.FileName;
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images/ProfilePictures", uniqueFileName);
            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }
            return Ok(uniqueFileName);
        }

        // POST: api/Users/CoverPicture/
        [HttpPost]
        [Route("CoverPicture")]
        public async Task<IActionResult> CoverPicture([FromForm(Name = "file")] IFormFile formFile)
        {
            string uniqueFileName = Guid.NewGuid().ToString("N") + formFile.FileName;
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images/CoverPictures", uniqueFileName);
            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }
            return Ok(uniqueFileName);
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(User user)
        {
            return Ok(unitOfWork.Users.UpdateUser(user));
        }

        [HttpGet]
        [Route("Simple/{id}")]
        public async Task<IActionResult> GetSimpleUser(Guid id)
        {
            return Ok(await unitOfWork.Users.GetUserSimple(id));
        }

        [HttpGet]
        [Route("SimpleProfile/{id}")]
        public async Task<IActionResult> GetSimpleProfile(Guid id)
        {
            return Ok(await unitOfWork.Users.GetUserSimpleProfile(id));
        }

        [HttpGet]
        [Route("Simple")]
        public async Task<IActionResult> GetSimpleUsers()
        {
            return Ok(await unitOfWork.Users.GetUsersSimple());
        }

        [HttpGet]
        [Route("ChatUsersSimple/{chatId}")]
        public async Task<IActionResult> GetChatUsers(Guid chatId)
        {
            return Ok(await unitOfWork.Users.GetChatUsersSimple(chatId));
        }

        [HttpGet]
        [Route("RemainingUsersSimple/{chatId}")]
        public IActionResult GetRemainingUsersSimple(Guid chatId)
        {
            return Ok(unitOfWork.Users.GetRemainingUsersSimple(chatId));//geeft alle userDTO's die geen lid van de chat zijn
        }

        [HttpPut]
        [Route("UpdateUserInfo")]
        public async Task<IActionResult> UpdateUserInfo(UserProfileDTO userProfile)
        {
            Guid id = userProfile.Id;
            User user = unitOfWork.Users.FindById(id);
            if (await unitOfWork.Users.FindUserByUserName(userProfile.UserName) == null) user.UserName = userProfile.UserName;
            user.FirstName = userProfile.FirstName;
            user.LastName = userProfile.LastName;
            return Update(user);
        }

        [HttpPut]
        [Route("UpdatePokeInfo")]
        public IActionResult UpdatePokeInfo(UserProfilePokeDTO userProfilePoke)
        {
            //een niet valid object zal niet toekomen in deze method, zelfs niet wanneer js wordt uitgeschakeld
            Guid id = userProfilePoke.Id;
            User user = unitOfWork.Users.FindById(id);
            user.FavoritePokemon = userProfilePoke.FavoritePokemon;
            user.FavoritePokemonGame = userProfilePoke.FavoritePokemonGame;
            return Update(user);
        }

        [HttpGet]
        [Route("NewChatUsers/{userId}")]
        public async Task<IActionResult> GetNewChatUsers(Guid userId)//Hier bepalen we de users waar je nog geen chat mee hebt
        {
            User me = unitOfWork.Users.FindById(userId);
            List<string> individualUserNames = new List<string>();
            var chatList = unitOfWork.Chats.FindChatsForUser(userId).Where(c => c.NumberOfUsers == 2).ToList();
            foreach(var chat in chatList)
            {
                foreach(var uc in chat.UserChats)
                {
                    if (uc.User.UserName != me.UserName) individualUserNames.Add(uc.User.UserName);
                }
            }
            individualUserNames.Add(me.UserName);
            List<UserSimpleDTO> usersSimple = await unitOfWork.Users.GetUsersSimple();
            for(int i=0; i<usersSimple.Count(); i++)
            {
                var cur = usersSimple[i];
                if (individualUserNames.Contains(cur.UserName))
                {
                    usersSimple.RemoveAt(i);
                    i--;
                }
            }
            return Ok(usersSimple);
        }
    }
}