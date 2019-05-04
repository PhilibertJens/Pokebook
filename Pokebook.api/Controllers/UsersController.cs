using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
        public IActionResult GetUserWithUserName(string userName)
        {
            return Ok(unitOfWork.Users.FindUserByUserName(userName));
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
            return Ok(new { count = 1, formFile.Length, uniqueFileName });
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(User user)
        {
            return Ok(unitOfWork.Users.UpdateUser(user));
        }

        [HttpGet]
        [Route("Simple/{id}")]
        public async Task<IActionResult> GetSimpleUser(Guid id)
        {
            return Ok(unitOfWork.Users.GetUserSimple(id));
        }

        [HttpPut]
        [Route("UpdateUserInfo")]
        public async Task<IActionResult> UpdateUserInfo(UserProfileDTO userProfile)
        {
            Guid id = userProfile.Id;
            User user = unitOfWork.Users.FindById(id);
            if(userProfile.FirstName != "") user.FirstName = userProfile.FirstName;
            if (userProfile.LastName != "") user.LastName = userProfile.LastName;
            if (userProfile.UserName != "") user.UserName = userProfile.UserName;
            return await Update(user);
        }

        [HttpPut]
        [Route("UpdatePokeInfo")]
        public async Task<IActionResult> UpdatePokeInfo(UserProfilePokeDTO userProfilePoke)
        {
            Guid id = userProfilePoke.Id;
            User user = unitOfWork.Users.FindById(id);
            if (userProfilePoke.FavoritePokemon != "") user.FavoritePokemon = userProfilePoke.FavoritePokemon;
            if (userProfilePoke.FavoritePokemonGame != "") user.FavoritePokemonGame = userProfilePoke.FavoritePokemonGame;
            return await Update(user);
        }

        //[HttpPost]
        //[Route("{User}")]
        //public IActionResult AddNewUser(User user)
        //{
        //    //return Ok(unitOfWork.Users.Add(user)); --> werkt niet omdat de Id al bepaald is voor de Add method wordt uitgevoerd
        //    return Ok(Post(user));
        //}
    }
}