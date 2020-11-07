using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using Pokebook.web.Helpers;
using Pokebook.web.Models;
using Type = Pokebook.core.Models.Type;

namespace Pokebook.web.Controllers
{
    public class ExploreController : Controller
    {
        public ExploreController()
        {
            Constants constants = new Constants();
            //baseuri = $"https://localhost:{constants.Portnumber}/api";
            baseuri = $"{constants.ApiServerSideAddress}/api";
            baseuriClient = $"{constants.ApiClientSideAddress}/api";
            random = new Random();
        }
        
        readonly string baseuri;
        readonly string baseuriClient;
        private Random random;

        public Guid? CheckSession()
        {
            string id = HttpContext.Session.GetString("UserId");
            if (id != null) return Guid.Parse(id);
            else return null;
        }

        public IActionResult WalkAround()
        {
            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;
            
            HttpContext.Session.Remove("PokemonData");
            var listEnvironments = new List<SelectListItem> {
                new SelectListItem { Value = "0", Text = "== Where are you? ==" },
                new SelectListItem { Value = "1", Text = "In a forest" },
                new SelectListItem { Value = "2", Text = "In the deep sea" },
                new SelectListItem { Value = "3", Text = "In the busy street of the city" },
                new SelectListItem { Value = "4", Text = "High in the sky" },
                new SelectListItem { Value = "5", Text = "In the mountains" },
                new SelectListItem { Value = "6", Text = "In a dark cave" }
            };

            var listDayTime = new List<SelectListItem> {
                new SelectListItem { Value = "0", Text = "== When are you? ==" },
                new SelectListItem { Value = "1", Text = "Morning" },
                new SelectListItem { Value = "2", Text = "Midday" },
                new SelectListItem { Value = "3", Text = "Evening" },
                new SelectListItem { Value = "4", Text = "Midnight" }
            };
            ExploreWalkAroundVm vm = new ExploreWalkAroundVm();
            vm.SelectedEnvironmentId = 0;
            vm.Environments = listEnvironments;
            vm.DayTime = listDayTime;
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> WalkAround(ExploreWalkAroundVm userData)//bevat een omgeving en tijdstip
        {
            if (ModelState.IsValid)
            {
                Type foundType = await FindType(userData.SelectedEnvironmentId, userData.SelectedDayTimeId);
                PokemonSessionData pokemonData = new PokemonSessionData();
                pokemonData.Type = foundType.Name;
                string serializedPokemonData = JsonConvert.SerializeObject(pokemonData);
                HttpContext.Session.SetString("PokemonData", serializedPokemonData);
                return new RedirectToActionResult("GeneratePokemon", "Explore", null);
            }
            else return View(userData);
        }

        public async Task<IActionResult> GeneratePokemon()
        {
            PokemonCatch appearedPokemon;
            Pokemon template;
            PokemonSessionData pokemonData;
            string serializedPokemon;

            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;

            UserSimpleDTO user = await GetUserWithId(userId);
            
            serializedPokemon = HttpContext.Session.GetString("PokemonData");
            if (PokemonErrorCheck(serializedPokemon)) return new RedirectToActionResult("Walkaround", "Explore", null);

            pokemonData = JsonConvert.DeserializeObject<PokemonSessionData>(serializedPokemon);

            string uri = $"{baseuri}/Types/TypeName/{pokemonData.Type}";
            var getType = await WebApiHelper.GetApiResult<Type>(uri);
            
            if (pokemonData.Name == null)//er is nog geen pokemon gegenereerd. Is dit wel zo zal de bovenstaande terug getoond worden
                appearedPokemon = await LetPokemonAppear(getType, user.Id);
            else appearedPokemon = GetPokemonCatchObject(pokemonData.Id, userId, pokemonData.HP, pokemonData.CP, 
                                                         pokemonData.Height, pokemonData.Weight, pokemonData.Gender, 
                                                         pokemonData.IsShiny, pokemonData.IsAlolan, pokemonData.MoveCatches);

            uri = $"{baseuri}/Pokemons/GetById/{appearedPokemon.PokemonId}";
            template = await WebApiHelper.GetApiResult<Pokemon>(uri);

            appearedPokemon.Pokemon = template;
            ExploreCatchVm vm = new ExploreCatchVm();
            vm.AppearedPokemon = appearedPokemon;
            vm.CheatingWarning = pokemonData.CheatingWarning;
            vm.UserName = user.UserName;
            vm.BaseUri = baseuriClient;
            vm.FolderType = GeneralFunctions.EvaluateFolderType(appearedPokemon.IsShiny, appearedPokemon.IsAlolan);//FolderType is ook property van PokemonCatch
            return View(vm);
        }

        public async Task<IActionResult> CatchProcesser()
        {
            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;

            UserSimpleDTO user = await GetUserWithId(userId);
            
            string serializedPokemon = HttpContext.Session.GetString("PokemonData");
            if (PokemonErrorCheck(serializedPokemon)) return new RedirectToActionResult("Walkaround", "Explore", null);

            var pokemonData = JsonConvert.DeserializeObject<PokemonSessionData>(serializedPokemon);

            string uri = $"{baseuri}/Pokemons/GetById/{pokemonData.Id}";
            Pokemon template = await WebApiHelper.GetApiResult<Pokemon>(uri);
            PokemonCatch appearedPokemon = GetPokemonCatchObject(pokemonData.Id, userId, pokemonData.HP, pokemonData.CP, 
                                                                 pokemonData.Height, pokemonData.Weight, pokemonData.Gender,
                                                                 pokemonData.IsShiny, pokemonData.IsAlolan, pokemonData.MoveCatches);
            appearedPokemon.Pokemon = template;
            appearedPokemon.AppType = "Webbrowser";

            int luckyNumber = random.Next(0, 2);
            if (luckyNumber == 1)//50% dat de pokemon is gevangen.
            {
                pokemonData.Caught = true;/*om cheaten te vermijden*/
                string serializedPokemonData = JsonConvert.SerializeObject(pokemonData);
                HttpContext.Session.SetString("PokemonData", serializedPokemonData);

                uri = $"{baseuri}/PokemonCatches/Add";
                //var AddedPokemonId = await WebApiHelper.PostCallAPI<Guid, PokemonCatch>(uri, appearedPokemon);
                var AddedPokemonId = await WebApiHelperPost.PostAsyncGuid(uri, appearedPokemon);

                uri = $"{baseuri}/PokemonMoveCatches/Add";
                foreach(var el in appearedPokemon.PokemonMoveCatches) {
                    el.PokemonId = AddedPokemonId;
                    //await WebApiHelper.PostCallAPI<PokemonMoveCatch, PokemonMoveCatch>(uri, el);
                    await WebApiHelperPost.PostAsync(uri, el);
                }

                uri = $"{baseuri}/PokemonUsers/GetById/{pokemonData.Id}/{userId}";
                PokemonUser alreadyCaught = await WebApiHelper.GetApiResult<PokemonUser>(uri);//user heeft resp pokemon al gevangen
                if(alreadyCaught == null)
                {
                    PokemonUser pokemonUser = new PokemonUser()
                    {
                        PokemonId = pokemonData.Id,
                        UserId = userId,
                        Catches = 1
                    };

                    uri = $"{baseuri}/PokemonUsers/Add";
                    //await WebApiHelper.PostCallAPI<PokemonUser, PokemonUser>(uri, pokemonUser);
                    await WebApiHelperPost.PostAsync(uri, pokemonUser);
                }
                else
                {
                    uri = $"{baseuri}/PokemonUsers/UpdateAdd";
                    //await WebApiHelper.PutCallAPI<PokemonUser, PokemonUser>(uri, alreadyCaught);
                    await WebApiHelperPost.PutAsync(uri, alreadyCaught);
                }
                return new RedirectToActionResult("Gotcha", "Explore", null);
            }
            else
            {
                pokemonData.CheatingWarning = null;
                string serializedPokemonData = JsonConvert.SerializeObject(pokemonData);
                HttpContext.Session.SetString("PokemonData", serializedPokemonData);
                return new RedirectToActionResult("TryAgain", "Explore", null);
                //om een refresh bij CatchProcesser te voorkomen word je weggestuurd
            }
        }

        public async Task<IActionResult> TryAgain()
        {
            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;

            UserSimpleDTO user = await GetUserWithId(userId);
            
            string serializedPokemon = HttpContext.Session.GetString("PokemonData");
            if (PokemonErrorCheck(serializedPokemon)) return new RedirectToActionResult("Walkaround", "Explore", null);

            var pokemonData = JsonConvert.DeserializeObject<PokemonSessionData>(serializedPokemon);

            string uri = $"{baseuri}/Pokemons/GetById/{pokemonData.Id}";
            Pokemon template = await WebApiHelper.GetApiResult<Pokemon>(uri);
            PokemonCatch appearedPokemon = GetPokemonCatchObject(pokemonData.Id, userId, pokemonData.HP, pokemonData.CP, 
                                                                 pokemonData.Height, pokemonData.Weight, pokemonData.Gender,
                                                                 pokemonData.IsShiny, pokemonData.IsAlolan, pokemonData.MoveCatches);
            appearedPokemon.Pokemon = template;

            ExploreCatchVm vm = new ExploreCatchVm();
            vm.AppearedPokemon = appearedPokemon;
            vm.UserName = user.UserName;
            vm.BaseUri = baseuriClient;
            vm.FolderType = GeneralFunctions.EvaluateFolderType(appearedPokemon.IsShiny, appearedPokemon.IsAlolan);
            return View(vm);
        }

        public async Task<IActionResult> Gotcha()
        {
            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;

            UserSimpleDTO user = await GetUserWithId(userId);
            
            string serializedPokemon = HttpContext.Session.GetString("PokemonData");
            if (PokemonErrorCheck(serializedPokemon)) return new RedirectToActionResult("Walkaround", "Explore", null);
            var pokemonData = JsonConvert.DeserializeObject<PokemonSessionData>(serializedPokemon);

            if (!pokemonData.Caught)
            {/*de bool is niet op true gezet in CatchProcesser. De user heeft dus gecheat*/
                pokemonData.CheatingWarning = "Professor Oak can't allow cheating!";
                string serializedPokemonData = JsonConvert.SerializeObject(pokemonData);
                HttpContext.Session.SetString("PokemonData", serializedPokemonData);
                return new RedirectToActionResult("GeneratePokemon", "Explore", null);
            }

            string uri = $"{baseuri}/Pokemons/GetById/{pokemonData.Id}";
            Pokemon template = await WebApiHelper.GetApiResult<Pokemon>(uri);
            PokemonCatch appearedPokemon = GetPokemonCatchObject(pokemonData.Id, userId, pokemonData.HP, pokemonData.CP, 
                                                                 pokemonData.Height, pokemonData.Weight, pokemonData.Gender,
                                                                 pokemonData.IsShiny, pokemonData.IsAlolan, pokemonData.MoveCatches);
            appearedPokemon.Pokemon = template;

            ExploreCatchVm vm = new ExploreCatchVm();
            vm.AppearedPokemon = appearedPokemon;
            vm.UserName = user.UserName;
            vm.BaseUri = baseuriClient;
            vm.FolderType = GeneralFunctions.EvaluateFolderType(appearedPokemon.IsShiny, appearedPokemon.IsAlolan);
            HttpContext.Session.Remove("PokemonData");//om minder geheugen in te nemen op de server.
                                                      //Ook om een Redirect te forceren bij terugkeer naar de vorige pagina
            return View(vm);
        }

        public PokemonCatch GetPokemonCatchObject(Guid pokemonId, Guid userId, int HP, int CP, float height, float weight, bool gender, bool isShiny, bool isAlolan, ICollection<PokemonMoveCatch> moveCatches)
        {
            return new PokemonCatch
            {
                PokemonId = pokemonId,
                UserId = userId,
                HP = HP,
                CP = CP,
                Height = height,
                Weight = weight,
                Gender = gender,
                IsShiny = isShiny,
                IsAlolan = isAlolan,
                FolderType = GeneralFunctions.EvaluateFolderType(isShiny, isAlolan),
                PokemonMoveCatches = moveCatches
            };
        }

        private bool UserNameErrorCheck(string userName)
        {
            return userName == null;
        }

        private bool PokemonErrorCheck(string serializedPokemon)
        {
            return serializedPokemon == null;
        }

        public async Task<UserSimpleDTO> GetUserWithId(Guid userId)
        {
            string uri = $"{baseuri}/users/{userId}";
            return await WebApiHelper.GetApiResult<UserSimpleDTO>(uri);
        }

        private async Task<PokemonCatch> LetPokemonAppear(Type type, Guid userId)
        {
            string uri = $"{baseuri}/PokemonTypes/GetByTypeName/{type.Name}";
            List<Pokemon> GetPokemonWithType = await WebApiHelper.GetApiResult<List<Pokemon>>(uri);

            int max = GetPokemonWithType.Count();
            if (max != 0)
            {
                int listItem = random.Next(0, max);
                var appearedPokemon = GetPokemonWithType[listItem];

                uri = $"{baseuri}/PokemonCatches/CreateFromTemplate/{appearedPokemon.Id}/{userId}";
                PokemonCatch generatedPokemon = await WebApiHelper.GetApiResult<PokemonCatch>(uri);

                string serializedPokemon = HttpContext.Session.GetString("PokemonData");
                var pokemonData = JsonConvert.DeserializeObject<PokemonSessionData>(serializedPokemon);
                pokemonData.Name = appearedPokemon.Name;
                pokemonData.Id = appearedPokemon.Id;
                pokemonData.HP = generatedPokemon.HP;
                pokemonData.CP = generatedPokemon.CP;
                pokemonData.Height = generatedPokemon.Height;
                pokemonData.Weight = generatedPokemon.Weight;
                pokemonData.MoveCatches = generatedPokemon.PokemonMoveCatches;
                pokemonData.Gender = generatedPokemon.Gender;
                pokemonData.IsShiny = generatedPokemon.IsShiny;
                pokemonData.IsAlolan = generatedPokemon.IsAlolan;
                string serializedPokemonData = JsonConvert.SerializeObject(pokemonData);
                HttpContext.Session.SetString("PokemonData", serializedPokemonData);

                return generatedPokemon;
            }
            else return null;
        }

        private async Task<Type> FindType(int environmentId, int timeId)
        {
            List<List<string>> environments = new List<List<string>>()
            {
                new List<string>(){ "Grass", "Fire", "Water", "Bug", "Normal" },//default
                new List<string>(){ "Grass", "Bug", "Psychic" },//forest
                new List<string>(){ "Water", "Water", "Water", "Water" },//sea
                new List<string>(){ "Fighting", "Electric", "Fire" },//city
                new List<string>(){ "Flying", "Flying", "Dragon", "Dragon" },//sky
                new List<string>(){ "Grass", "Ground", "Rock", "Ice" },//mountain
                new List<string>(){ "Poison", "Bug", "Dragon", "Ghost" }//cave
            };
            List<List<string>> daytimes = new List<List<string>>()
            {
                new List<string>(){ "Water", "Bug" },//default
                new List<string>(){ "Normal" },//morning
                new List<string>(){ "Normal" },//midday
                new List<string>(){ "Normal", "Ghost", "Ghost", "Ghost", "Ghost" },//evening
                new List<string>(){ "Normal", "Ghost", "Ghost", "Ghost", "Ghost" },//midnight
            };
            List<string> typesPerEnvironment = environments[environmentId];
            List<string> typesPerDaytime = daytimes[timeId];
            List<string> summary = new List<string>();
            foreach (string type in typesPerEnvironment) summary.Add(type);
            foreach (string type in typesPerDaytime) summary.Add(type);

            string selectedType = summary[random.Next(0, summary.Count())];

            string uri = $"{baseuri}/Types/TypeName/{selectedType}";
            var getType = await WebApiHelper.GetApiResult<Type>(uri);
            
            return getType;
        }
    }
}