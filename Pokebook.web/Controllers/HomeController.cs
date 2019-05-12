﻿using System;
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

        public IActionResult Index()
        {
            Guid userId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            string uri = $"{baseuri}/users/{userId}";
            User user = WebApiHelper.GetApiResult<User>(uri);
            List<User> friends = GetFriends(user);
            HomeIndexVM vm = new HomeIndexVM
            {
                Me = user,
                //FriendsToApprove = friends
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
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
