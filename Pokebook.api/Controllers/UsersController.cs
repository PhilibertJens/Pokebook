﻿using System;
using System.Collections.Generic;
using System.IO;
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

        



        //[HttpPost]
        //[Route("{User}")]
        //public IActionResult AddNewUser(User user)
        //{
        //    //return Ok(unitOfWork.Users.Add(user)); --> werkt niet omdat de Id al bepaald is voor de Add method wordt uitgevoerd
        //    return Ok(Post(user));
        //}
    }
}