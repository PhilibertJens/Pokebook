using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Models;
using Pokebook.web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Components
{
    public class ShowUsernameViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string baseuri = "https://localhost:44321/api";
            if (HttpContext.Session.GetString("UserId") != null)
            {
                Guid userId = Guid.Parse(HttpContext.Session.GetString("UserId"));
                var uri = $"{baseuri}/users/{userId}";
                var currentUser = WebApiHelper.GetApiResult<User>(uri);
                return View(currentUser);
            }
            return View(null);
        }
    }
}
