using System;
using System.Collections.Generic;
using System.Linq;
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
        public ExploreController(PokebookContext context)
        {
            Constants constants = new Constants();
            baseuri = $"https://localhost:{constants.Portnumber}/api";
            random = new Random();
            pokebookContext = context;
        }

        private PokebookContext pokebookContext;
        readonly string baseuri;
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
            //string userName = HttpContext.Session.GetString("Username");
            //if (userName == null) return new RedirectToActionResult("Login", "Account", null);
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
        public IActionResult WalkAround(ExploreWalkAroundVm userData)//bevat een omgeving en tijdstip
        {
            if (ModelState.IsValid)
            {
                Type foundType = FindType(userData.SelectedEnvironmentId, userData.SelectedDayTimeId);
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
            Pokemon appearedPokemon;
            PokemonSessionData pokemonData;
            string serializedPokemon, userName;

            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;

            UserSimpleDTO user = await GetUserWithId(userId);
            //userName = HttpContext.Session.GetString("Username");
            //if (UserNameErrorCheck(userName)) return new RedirectToActionResult("Login", "Account", null);
            serializedPokemon = HttpContext.Session.GetString("PokemonData");
            if (PokemonErrorCheck(serializedPokemon)) return new RedirectToActionResult("Walkaround", "Explore", null);

            pokemonData = JsonConvert.DeserializeObject<PokemonSessionData>(serializedPokemon);
            var getType = pokebookContext.Types
                .Where(t => t.Name == pokemonData.Type).FirstOrDefault();
            if (pokemonData.Name == null)//er is nog geen pokemon gegenereerd. Is dit wel zo zal de bovenstaande terug getoond worden
            {
                appearedPokemon = await LetPokemonAppear(getType);
                serializedPokemon = HttpContext.Session.GetString("PokemonData");
                pokemonData = JsonConvert.DeserializeObject<PokemonSessionData>(serializedPokemon);
            }

            appearedPokemon = pokebookContext.Pokemons
                    .Where(p => p.Name == pokemonData.Name).FirstOrDefault();

            ExploreCatchVm vm = new ExploreCatchVm();
            vm.AppearedPokemon = appearedPokemon;
            vm.HP = pokemonData.HP;
            vm.Moves = pokemonData.Moves;
            vm.CheatingWarning = pokemonData.CheatingWarning;
            vm.UserName = user.UserName;
            return View(vm);
        }

        public async Task<IActionResult> CatchProcesser()
        {
            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;

            UserSimpleDTO user = await GetUserWithId(userId);
            //string userName = HttpContext.Session.GetString("Username");
            //if (UserNameErrorCheck(userName)) return new RedirectToActionResult("Login", "Account", null);
            string serializedPokemon = HttpContext.Session.GetString("PokemonData");
            if (PokemonErrorCheck(serializedPokemon)) return new RedirectToActionResult("Walkaround", "Explore", null);

            var pokemonData = JsonConvert.DeserializeObject<PokemonSessionData>(serializedPokemon);
            var getPokemon = pokebookContext.Pokemons
                    .Where(p => p.Name == pokemonData.Name).FirstOrDefault();

            int luckyNumber = random.Next(0, 2);
            if (luckyNumber == 1)//50% dat de pokemon is gevangen.
            {
                pokemonData.Caught = true;/*om cheaten te vermijden*/
                string serializedPokemonData = JsonConvert.SerializeObject(pokemonData);
                HttpContext.Session.SetString("PokemonData", serializedPokemonData);

                var me = pokebookContext.Users
                    .Where(u => u.UserName == user.UserName).FirstOrDefault();
                try
                {
                    var alreadyCaught = pokebookContext.PokemonUsers
                                   .Where(pu => pu.UserId == me.Id && pu.PokemonId == getPokemon.Id).FirstOrDefault(); //user heeft resp pokemon al gevangen
                    alreadyCaught.Catches++;
                }
                catch (NullReferenceException)
                {//als de user nog geen pokemon van dit type heeft
                    PokemonUser pokemonUser = new PokemonUser()
                    {
                        PokemonId = getPokemon.Id,
                        UserId = me.Id,
                        Catches = 1
                    };
                    pokebookContext.PokemonUsers.Add(pokemonUser);
                }
                await pokebookContext.SaveChangesAsync();
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
            //string userName = HttpContext.Session.GetString("Username");
            //if (UserNameErrorCheck(userName)) return new RedirectToActionResult("Login", "Account", null);
            string serializedPokemon = HttpContext.Session.GetString("PokemonData");
            if (PokemonErrorCheck(serializedPokemon)) return new RedirectToActionResult("Walkaround", "Explore", null);

            var pokemonData = JsonConvert.DeserializeObject<PokemonSessionData>(serializedPokemon);
            var getPokemon = pokebookContext.Pokemons
                    .Where(p => p.Name == pokemonData.Name).FirstOrDefault();

            ExploreCatchVm vm = new ExploreCatchVm();
            vm.AppearedPokemon = getPokemon;
            vm.HP = pokemonData.HP;
            vm.Moves = pokemonData.Moves;
            vm.UserName = user.UserName;
            return View(vm);
        }

        public async Task<IActionResult> Gotcha()
        {
            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;

            UserSimpleDTO user = await GetUserWithId(userId);
            //string userName = HttpContext.Session.GetString("Username");
            //if (UserNameErrorCheck(userName)) return new RedirectToActionResult("Login", "Account", null);
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

            var getPokemon = pokebookContext.Pokemons
                    .Where(p => p.Name == pokemonData.Name).FirstOrDefault();
            ExploreCatchVm vm = new ExploreCatchVm();
            vm.AppearedPokemon = getPokemon;
            vm.HP = pokemonData.HP;
            vm.Moves = pokemonData.Moves;
            vm.UserName = user.UserName;
            HttpContext.Session.Remove("PokemonData");//om minder geheugen in te nemen op de server.
                                                      //Ook om een Redirect te forceren bij terugkeer naar de vorige pagina
            return View(vm);
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

        private async Task<Pokemon> LetPokemonAppear(Type type)
        {
            var givePokemonType = await pokebookContext.Set<PokemonType>()//een join van Pokemon, PokemonType en Type
                                            .Include(pt => pt.Pokemon)
                                            .ThenInclude(p => p.PokemonTypes)
                                            .Where(p => p.Type.Name.ToLower() == type.Name.ToLower())
                                            .Include(pt => pt.Type)
                                            .ThenInclude(t => t.PokemonTypes)
                                            .ToListAsync();
            int max = givePokemonType.Count();
            if (max != 0)
            {
                int listItem = random.Next(0, max);
                var appearedPokemon = givePokemonType[listItem];//geeft een Pokemon met type. Moet omgezet worden naar een Pokemon
                                                                //HttpContext.Session.SetString("AppearedPokemon", appearedPokemon.Pokemon.Name);
                string serializedPokemon = HttpContext.Session.GetString("PokemonData");
                var pokemonData = JsonConvert.DeserializeObject<PokemonSessionData>(serializedPokemon);
                pokemonData.Name = appearedPokemon.Pokemon.Name;
                pokemonData.Id = appearedPokemon.Pokemon.Id;
                pokemonData.HP = 50; //dit wordt random bepaald
                pokemonData.Moves = new List<string> { "Bite", "Shadowball" };//dit wordt bepaald per type
                string serializedPokemonData = JsonConvert.SerializeObject(pokemonData);
                HttpContext.Session.SetString("PokemonData", serializedPokemonData);

                return appearedPokemon.Pokemon;
            }
            else return null;
        }

        private Type FindType(int environmentId, int timeId)
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
            var getType = pokebookContext.Types
                .Where(t => t.Name == selectedType).FirstOrDefault();
            return getType;
        }
    }
}