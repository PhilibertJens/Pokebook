using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using Pokebook.web.Helpers;
using Pokebook.web.Models;

namespace Pokebook.web.Controllers
{
    public class ProfileController : Controller
    {
        public ProfileController()
        {
            Constants constants = new Constants();
            baseuri = $"https://localhost:{constants.Portnumber}/api";
        }
        
        string baseuri;

        public List<User> GetFriends(User user)
        {
            //Nu worden gewoon alle gebruikers getoond. Dit moeten je friends zijn
            string uri = $"{baseuri}/users";
            List<User> friends = WebApiHelper.GetApiResult<List<User>>(uri);
            return friends.Where(f => f.UserName != user.UserName).ToList();
        }

        public async Task<IActionResult> Index()
        {
            Guid userId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            string uri = $"{baseuri}/users/{userId}";
            User user = WebApiHelper.GetApiResult<User>(uri);

            List<User> friends = GetFriends(user);

            ProfileIndexVM vm = new ProfileIndexVM()
            {
                me = user,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                FavoritePokemon = user.FavoritePokemon,
                FavoritePokemonGame = user.FavoritePokemonGame,
                Friends = friends
            };
            return View(vm);
        }

        public bool Validate(ProfileIndexVM userdata)
        {
            if (userdata.ProfilePicture == null && userdata.UploadedCoverImage == null) return false;
            if (userdata.CoverPicture == null && userdata.UploadedProfileImage == null) return false;
            return true;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Change(ProfileIndexVM userdata)
        {
            Guid userId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            string uri = $"{baseuri}/users/{userId}";
            User user = WebApiHelper.GetApiResult<User>(uri);
            string responseFileName = "";
            if (Validate(userdata)){
            //if (ModelState.IsValid){ --> vervangen door eigen Validate method
                if(userdata.ProfilePicture == null) uri = $"{baseuri}/users/CoverPicture";
                else uri = $"{baseuri}/users/ProfilePicture";
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpContent fileStreamContent;
                    if (userdata.ProfilePicture == null)
                    {
                        fileStreamContent = new StreamContent(userdata.UploadedCoverImage.OpenReadStream());
                        fileStreamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                        {
                            Name = "file",
                            FileName = userdata.UploadedCoverImage.FileName
                        };
                    }
                    else
                    {
                        fileStreamContent = new StreamContent(userdata.UploadedProfileImage.OpenReadStream());
                        fileStreamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                        {
                            Name = "file",
                            FileName = userdata.UploadedProfileImage.FileName
                        }; 
                    }
                    fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                    using (var formData = new MultipartFormDataContent())
                    {
                        formData.Add(fileStreamContent);
                        HttpResponseMessage response = await httpClient.PostAsync(uri, formData);
                        responseFileName = await response.Content.ReadAsStringAsync();
                    }
                }
                if (responseFileName != "")
                {
                    if (userdata.ProfilePicture == null) user.CoverPicture = responseFileName;
                    else user.ProfilePicture = responseFileName;
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

        public async Task<IActionResult> FriendProfile(string username)
        {
            Guid userId = Guid.Parse(HttpContext.Session.GetString("UserId"));
            string uri = $"{baseuri}/users/{userId}";
            User user = WebApiHelper.GetApiResult<User>(uri);

            uri = $"{baseuri}/users/userName/{username}";
            User friend = WebApiHelper.GetApiResult<User>(uri);
            List<User> friends = GetFriends(friend);

            bool userIsfriend = IsUserFriend(user, friend);

            ProfileFriendVM vm = new ProfileFriendVM()
            {
                Me = user,
                Friend = friend,
                FriendsOfFriend = friends,
                UserIsFriend = userIsfriend
            };
            return View(vm);
        }

        private bool IsUserFriend(User me, User friend)
        {
            string uri = $"{baseuri}/friendships/GetFriendship/{me.Id}/{friend.Id}";
            Friendship friendship = WebApiHelper.GetApiResult<Friendship>(uri);//nu moet er nog gecheckt worden als de friendship is aanvaard
            return friendship != null;
        }
    }
}