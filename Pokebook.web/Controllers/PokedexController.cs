using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using Pokebook.web.Helpers;
using Pokebook.web.Models;

namespace Pokebook.web.Controllers
{
    public class PokedexController : Controller
    {
        public PokedexController(PokebookContext context)
        {
            Constants constants = new Constants();
            baseuri = $"{constants.ApiServerSideAddress}/api";
            pokemonContext = context;
        }

        readonly string baseuri;
        private PokebookContext pokemonContext;

        public Guid? CheckSession()
        {
            string id = HttpContext.Session.GetString("UserId");
            if (id != null) return Guid.Parse(id);
            else return null;
        }

        public async Task<UserSimpleDTO> GetUserWithId(Guid userId)
        {
            string uri = $"{baseuri}/users/{userId}";
            return await WebApiHelper.GetApiResult<UserSimpleDTO>(uri);
        }

        public async Task<IActionResult> Index()
        {
            Guid userId;
            Guid? tempUserId = CheckSession();
            if (tempUserId == null) return new RedirectToActionResult("Login", "Account", null);
            else userId = (Guid)tempUserId;

            UserSimpleDTO user = await GetUserWithId(userId);

            var vm = new PokedexIndexVM
            {
                Username = user.UserName
            };

            string uri = $"{baseuri}/Pokemons/GetAll";
            List<Pokemon> allPokemon = await WebApiHelper.GetApiResult<List<Pokemon>>(uri);
            vm.AllPokemonWithTypeInfo = allPokemon;

            uri = $"{baseuri}/PokemonCatches/GetMyPokemon/{user.Id}";
            List<PokemonCatch> allCaughtPokemon = await WebApiHelper.GetApiResult<List<PokemonCatch>>(uri);
            vm.AllCaughtPokemon = allCaughtPokemon;

            return View(vm);
        }

        /*public async Task<IActionResult> Pokemon(short ndex)
        {
            string userName = HttpContext.Session.GetString("Username");
            if (userName == null) return new RedirectToActionResult("Login", "Account", null);

            var thisPoke = await pokemonContext.Pokemons
                .Include(p => p.PokemonTypes).ThenInclude(pt => pt.Type)
                .Where(p => p.NDex == ndex)
                .FirstOrDefaultAsync();

            thisPoke.PokemonUsers = await pokemonContext.PokemonUsers
                .Include(pu => pu.User)
                .Where(pu => pu.PokemonId == thisPoke.Id && pu.User.UserName == userName)
                .ToListAsync();

            short catches;
            if (thisPoke.PokemonUsers.FirstOrDefault() == null) catches = 0;
            else catches = thisPoke.PokemonUsers.FirstOrDefault().Catches;

            StringBuilder sb = new StringBuilder();
            var colors = new string[2];
            colors[0] = thisPoke.PokemonTypes.FirstOrDefault().Type.Colour;
            colors[1] = (thisPoke.PokemonTypes.Count < 2) ? colors[0] : thisPoke.PokemonTypes.ElementAtOrDefault(1).Type.Colour;
            foreach (var t in thisPoke.PokemonTypes) sb.Append($"{t.Type.Name} ");

            PokedexPokemonVM vm = new PokedexPokemonVM
            {
                SelectedPokemon = thisPoke,
                Catches = catches,
                Colors = colors,
                Sb = sb
            };

            return View(vm);
        }

        public IActionResult Error(int? statusCode) //refactor to simplicity/more use
        {
            string userName = HttpContext.Session.GetString("Username");
            if (userName == null) return new RedirectToActionResult("Login", "Account", null);

            if (statusCode.HasValue)
            {
                int? vn = 200;
                switch (statusCode)
                {
                    case (int?)HttpStatusCode.NotFound:
                        vn = statusCode;
                        break;
                    default:
                        break;
                }
                return View($"Page{vn.ToString()}");
            }
            return View();
        }*/

        /*private async Task<IEnumerable<Pokemon>> getAllCaught(string username)
        {
            var numberOfPokemon = await pokemonContext.Set<PokemonUser>()
                    .Include(pu => pu.Pokemon).ThenInclude(p => p.PokemonUsers)
                    .Include(pu => pu.User).ThenInclude(u => u.PokemonUsers)
                    .Where(u => u.User.Username == username)
                    .CountAsync();

            List<Pokemon> myPokemonList = new List<Pokemon>();
            if (numberOfPokemon != 0)
            {
                var allPoke = await pokemonContext.Set<PokemonUser>()//all pokemonuser objects per current user
                    .Include(pu => pu.Pokemon).ThenInclude(p => p.PokemonUsers)
                    .Include(pu => pu.User).ThenInclude(u => u.PokemonUsers)
                    .Where(u => u.User.Username == username).ToListAsync();

                foreach (var el in allPoke) myPokemonList.Add(el.Pokemon);
            }
            else myPokemonList = new List<Pokemon>();
            return myPokemonList;
        }*/
    }
}