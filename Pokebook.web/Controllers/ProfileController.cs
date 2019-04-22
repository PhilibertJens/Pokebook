using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Models;
using Pokebook.web.Helpers;
using Pokebook.web.Models;

namespace Pokebook.web.Controllers
{
    public class ProfileController : Controller
    {
        string baseuri = "https://localhost:44321/api";//poortnummer aanpassen!

        public async Task<IActionResult> Index()
        {
            Guid userId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            string uri = $"{baseuri}/users/{userId}";
            User user = WebApiHelper.GetApiResult<User>(uri);
            ProfileIndexVM vm = new ProfileIndexVM()
            {
                me = user
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Change(ProfileIndexVM userdata)
        {
            Guid userId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            string uri = $"{baseuri}/users/{userId}";
            User user = WebApiHelper.GetApiResult<User>(uri);
            string input = "";
            if (ModelState.IsValid)
            {
                uri = $"{baseuri}/users/ProfilePicture";
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpContent fileStreamContent = new StreamContent(userdata.UploadedImage.OpenReadStream());
                    fileStreamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                    {
                        Name = "file",
                        FileName = userdata.UploadedImage.FileName
                    };
                    fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                    using (var formData = new MultipartFormDataContent())
                    {
                        formData.Add(fileStreamContent);
                        HttpResponseMessage response = await httpClient.PostAsync(uri, formData);
                        input = await response.Content.ReadAsStringAsync();
                    }
                }
                if (input != "")
                {
                    user.ProfilePicture = userdata.UploadedImage.FileName;
                    uri = $"{baseuri}/users/update";
                    User updatedProfile = await WebApiHelper.PutCallAPI<User, User>(uri, user);
                }
                return new RedirectToActionResult("Index", "Profile", null);
            }
            
            ProfileIndexVM vm = new ProfileIndexVM()
            {
                me = user
            };
            return View("Index", vm);
        }
    }
}