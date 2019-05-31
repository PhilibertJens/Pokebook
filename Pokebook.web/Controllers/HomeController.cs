using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using Pokebook.web.Helpers;
using Pokebook.web.Models;

namespace Pokebook.web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Constants constants = new Constants();
            baseuri = $"https://localhost:{constants.Portnumber}/api";
        }

        readonly string baseuri;

        public Guid? CheckSession()
        {
            string id = HttpContext.Session.GetString("UserId");
            if (id != null) return Guid.Parse(id);
            else return null;
        }

        public async Task<IActionResult> Index()
        {
            Guid? userId = CheckSession();
            if (userId == null) return new RedirectToActionResult("Login", "Account", null);
            return View();
        }

        public IActionResult About()
        {
            Guid? userId = CheckSession();
            if (userId == null) return new RedirectToActionResult("Login", "Account", null);
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            Guid? userId = CheckSession();
            if (userId == null) return new RedirectToActionResult("Login", "Account", null);
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            Guid? userId = CheckSession();
            if (userId == null) return new RedirectToActionResult("Login", "Account", null);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            Guid? userId = CheckSession();
            if (userId == null) return new RedirectToActionResult("Login", "Account", null);
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
