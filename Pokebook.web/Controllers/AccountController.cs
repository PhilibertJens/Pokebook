using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Models;
using Pokebook.web.Helpers;
using Pokebook.web.Models;

namespace Pokebook.web.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {
            Constants constants = new Constants();
            baseuri = $"{constants.ApiServerSideAddress}/api";
        }
        
        readonly string baseuri;
        private PasswordHasher pH = new PasswordHasher();

        public IActionResult Login()
        {
            HttpContext.Session.Remove("UserId");
            AccountLoginVM vm = new AccountLoginVM();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AccountLoginVM userData)
        {
            if (ModelState.IsValid)
            {
                string uri = $"{baseuri}/users/username/{userData.UserName}";
                User currentUser = await WebApiHelper.GetApiResult<User>(uri);

                if (currentUser != null && verifyPassword(currentUser, userData.Password))//paswoord hash moet ook gecheckt worden
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
            HttpContext.Session.Remove("UserId");
            AccountRegisterVM vm = new AccountRegisterVM();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(AccountRegisterVM userData)
        {
            if (ModelState.IsValid)
            {
                string uri = $"{baseuri}/users/username/{userData.UserName}";
                User currentUser = await WebApiHelper.GetApiResult<User>(uri);
                if (currentUser == null)//user bestaat nog niet
                {
                    User newUser = new User()
                    {
                        FirstName = userData.FirstName,
                        LastName = userData.LastName,
                        UserName = userData.UserName,
                        PasswordHash = userData.Password
                    };
                    pH.HashPassword(newUser, newUser.PasswordHash);//het paswoord van de user wordt binnen deze functie vervangen
                    uri = $"{baseuri}/users";
                    User AddedUser = await WebApiHelper.PostCallAPI<User, User>(uri, newUser);

                    HttpContext.Session.SetString("UserId", AddedUser.Id.ToString());
                    return new RedirectToActionResult("RegisterSuccess", "Account", null);
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

        private bool verifyPassword(User user, string providedPW) => (pH.VerifyHashedPassword(user, user.PasswordHash, providedPW) == PasswordVerificationResult.Success);

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account", null);
        }
    }
}