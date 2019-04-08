using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pokebook.web.Models;

namespace Pokebook.web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        //login postmethod here

        public IActionResult Registration()
        {
            AccountRegisterVM vm = new AccountRegisterVM();
            return View(vm);
        }

        //register postmethod here
    }
}