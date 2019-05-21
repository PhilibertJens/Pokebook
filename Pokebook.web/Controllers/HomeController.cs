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

        string baseuri;

        public Guid? CheckSession()
        {
            string id = HttpContext.Session.GetString("UserId");
            if (id != null) return Guid.Parse(id);
            else return null;
        }

        public IActionResult Index()
        {
            Guid? userId = CheckSession();
            if (userId == null) return new RedirectToActionResult("Login", "Account", null);
            string uri = $"{baseuri}/users/{userId}";
            User user = WebApiHelper.GetApiResult<User>(uri);
            List<User> friends = GetFriends(user);
            HomeIndexVM vm = new HomeIndexVM
            {
                Me = user
            };
            return View(vm);
        }

        public List<User> GetFriends(User user)
        {
            string uri = $"{baseuri}/friendships/Get/{user.Id}";
            List<FriendWithFriendshipDTO> friendships = WebApiHelper.GetApiResult<List<FriendWithFriendshipDTO>>(uri);
            return friendships.Where(f => f.Friendship.Accepted == false && f.Friendship.IdApprover == user.Id)
                              .Select(f => f.Friend).ToList();
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
