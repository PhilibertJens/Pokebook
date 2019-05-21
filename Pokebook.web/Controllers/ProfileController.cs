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

        public Guid? CheckSession()
        {
            string id = HttpContext.Session.GetString("UserId");
            if (id != null) return Guid.Parse(id);
            else return null;
        }

        public async Task<List<User>> GetFriends(User user)
        {
            string uri = $"{baseuri}/friendships/Get/{user.Id}";
            List<FriendWithFriendshipDTO> friendships = await WebApiHelper.GetApiResult<List<FriendWithFriendshipDTO>>(uri);
            return friendships.Where(f => f.Friendship.Accepted == true).Select(f => f.Friend).ToList();
        }

        public async Task<IActionResult> Index()
        {
            Guid? userId = CheckSession();
            if (userId == null) return new RedirectToActionResult("Login", "Account", null);
            string uri = $"{baseuri}/users/{userId}";
            User user = await WebApiHelper.GetApiResult<User>(uri);

            List<User> friends = await GetFriends(user);

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

        public ImageUploadData GetImageUploadData(ProfileIndexVM userdata)
        {
            ImageUploadData imageUploadData = new ImageUploadData();

            if (userdata.ProfilePicture == null && userdata.UploadedCoverImage == null) return null;//kan gebeuren als de user de html wijzigt
            if (userdata.CoverPicture == null && userdata.UploadedProfileImage == null) return null;//kan gebeuren als de user de html wijzigt

            if (userdata.ProfilePicture != null && !userdata.UploadedProfileImage.ContentType.Contains("image"))
                return null;

            if (userdata.CoverPicture != null && !userdata.UploadedCoverImage.ContentType.Contains("image"))
                return null;

            if (userdata.ProfilePicture == null)
            {
                imageUploadData.Uri = $"{baseuri}/users/CoverPicture";
                imageUploadData.FileName = userdata.UploadedCoverImage.FileName;
                imageUploadData.Image = userdata.UploadedCoverImage.OpenReadStream();
            }
            else {
                imageUploadData.Uri = $"{baseuri}/users/ProfilePicture";
                imageUploadData.FileName = userdata.UploadedProfileImage.FileName;
                imageUploadData.Image = userdata.UploadedProfileImage.OpenReadStream();
            }
            return imageUploadData;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Change(ProfileIndexVM userdata)
        {
            Guid? userId = CheckSession();
            if (userId == null) return new RedirectToActionResult("Login", "Account", null);
            string uri = $"{baseuri}/users/{userId}";
            User user = await WebApiHelper.GetApiResult<User>(uri);
            string responseFileName = "";
            
            ImageUploadData imageUploadData = GetImageUploadData(userdata);
            if (imageUploadData == null) return new RedirectToActionResult("Index", "Profile", null);

            using (HttpClient httpClient = new HttpClient())
            {
                HttpContent fileStreamContent = new StreamContent(imageUploadData.Image);
                fileStreamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = imageUploadData.FileName
                };
                fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                var formData = new MultipartFormDataContent();
                formData.Add(fileStreamContent);
            
                HttpResponseMessage response = await httpClient.PostAsync(imageUploadData.Uri, formData);
                responseFileName = await response.Content.ReadAsStringAsync();
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

        public async Task<IActionResult> UserProfile(string username)
        {
            Guid? userId = CheckSession();
            if (userId == null) return new RedirectToActionResult("Login", "Account", null);
            string uri = $"{baseuri}/users/{userId}";
            User user = await WebApiHelper.GetApiResult<User>(uri);

            uri = $"{baseuri}/users/userName/{username}";
            User friend = await WebApiHelper.GetApiResult<User>(uri);
            if (friend != null)
            {
                List<User> friends = await GetFriends(friend);//de friends van deze friend
                Friendship friendship = await GetFriendship(user, friend);

                ProfileFriendVM vm = new ProfileFriendVM()
                {
                    Me = user,
                    Friend = friend,
                    FriendsOfFriend = friends,
                    Friendship = friendship
                    //3 situaties: user is friend; user must accept friendship request, user is no friend
                };
                return View(vm);
            }
            else return new RedirectToActionResult("Index", "Home", null);
        }

        private async Task<Friendship> GetFriendship(User me, User friend)
        {
            string uri = $"{baseuri}/friendships/GetFriendship/{me.Id}/{friend.Id}";
            Friendship friendship = await WebApiHelper.GetApiResult<Friendship>(uri);
            return friendship;
        }
    }
}