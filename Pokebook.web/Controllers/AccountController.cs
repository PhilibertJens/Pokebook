using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Models;
using Pokebook.web.Helpers;
using Pokebook.web.Models;

namespace Pokebook.web.Controllers
{
    public class AccountController : Controller
    {
        string baseuri = "https://localhost:44321/api";

        public IActionResult Login()
        {
            AccountLoginVM vm = new AccountLoginVM();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(AccountLoginVM userData)
        {
            if (ModelState.IsValid)
            {
                string uri = $"{baseuri}/users/{userData.UserName}";
                User currentUser = WebApiHelper.GetApiResult<User>(uri);

                if (currentUser != null)//paswoord hash moet ook gecheckt worden
                {
                    HttpContext.Session.SetString("UserId", currentUser.Id.ToString());
                    return new RedirectToActionResult("Index", "Home", null);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Username or password is incorrect. Professor Oak can't remember you.");
                    return View(userData);
                }

            }
            else return View(userData);
        }

        public IActionResult Registration()
        {
            AccountRegisterVM vm = new AccountRegisterVM();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(AccountRegisterVM userData)
        {
            if (ModelState.IsValid)
            {
                string uri = $"{baseuri}/users/{userData.UserName}";
                User currentUser = WebApiHelper.GetApiResult<User>(uri);
                if (currentUser == null)//user bestaat nog niet
                {
                    User newUser = new User()
                    {
                        FirstName = userData.FirstName,
                        LastName = userData.LastName,
                        UserName = userData.UserName,
                        PasswordHash = userData.Password//is momenteel nog niet gehasht
                    };

                    uri = $"{baseuri}/users/{newUser}";
                    User AddedUser = await WebApiHelper.PostCallAPI<User, User>(uri, newUser);

                    HttpContext.Session.SetString("UserId", newUser.Id.ToString());
                    return new RedirectToActionResult("Index", "Home", null);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "A trainer with that username already exists");
                    return View(userData);
                }

            }
            else return View(userData);
        }

        public IActionResult RegisterSuccess()
        {
            return View();
        }
    }
}