using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using Pokebook.web.Helpers;
using Pokebook.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Components
{
    public class UserListViewComponent : ViewComponent
    {
        public UserListViewComponent()
        {
            Constants constants = new Constants();
            baseuri = $"https://localhost:{constants.Portnumber}/api";
        }

        string baseuri;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (HttpContext.Session.GetString("UserId") != null)
            {
                Guid userId = Guid.Parse(HttpContext.Session.GetString("UserId"));
                var uri = $"{baseuri}/users/simple/{userId}";
                var userNameDTO = WebApiHelper.GetApiResult<UserSimpleDTO>(uri);
                uri = $"{baseuri}/users/simple";
                List<UserSimpleDTO> allUsers = WebApiHelper.GetApiResult<List<UserSimpleDTO>>(uri);
                allUsers = allUsers.Where(a => a.UserName != userNameDTO.UserName).ToList();

                AllUsersVM vm = new AllUsersVM
                {
                    AllUsers = allUsers
                };

                return View(vm);
            }
            return View(null);
        }
    }
}
