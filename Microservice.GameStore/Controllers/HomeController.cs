using Microservice.GameStore.Models;
using Microservice.GameStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Microservice.GameStore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task <IActionResult> Index()
        {
            using (var httpClient = new HttpClient())
            {
                //httpClient.BaseAddress = new Uri("https://localhost:7296");
                var responseGetGames = await httpClient.GetAsync("https://localhost:7296/api/produts/games");
                var responseGetShares = await httpClient.GetAsync("https://localhost:7296/api/shares/shares");
                if (responseGetGames.IsSuccessStatusCode && responseGetShares.IsSuccessStatusCode)
                {
                    var resultGames = await responseGetGames.Content.ReadAsStringAsync();
                    var resultShares = await responseGetGames.Content.ReadAsStringAsync();
                    List<GamesModel>? modelGames = JsonConvert.DeserializeObject<List<GamesModel>>(resultGames); 
                    List<SharesModel>? modelShares = JsonConvert.DeserializeObject<List<SharesModel>>(resultShares);

                    GamesAndSharesViewModel viewModel = new GamesAndSharesViewModel
                    {
                        Games = modelGames,
                        Shares = modelShares
                    };

                    return View(viewModel); 
                }
                return RedirectToAction("ErrorPage", "RedirectStatusCode");
            }   
        }
        [HttpGet]
        public async Task <IActionResult> Catalog()
        {
            using (var httpClient = new HttpClient())
            {
                //httpClient.BaseAddress = new Uri("https://localhost:7296");
                var responseGetGames = await httpClient.GetAsync("https://localhost:7296/api/produts/games");
                var responseGetShares = await httpClient.GetAsync("https://localhost:7296/api/shares/shares");
                if (responseGetGames.IsSuccessStatusCode && responseGetShares.IsSuccessStatusCode)
                {
                    var resultGames = await responseGetGames.Content.ReadAsStringAsync();
                    var resultShares = await responseGetGames.Content.ReadAsStringAsync();
                    List<GamesModel>? modelGames = JsonConvert.DeserializeObject<List<GamesModel>>(resultGames);
                    List<SharesModel>? modelShares = JsonConvert.DeserializeObject<List<SharesModel>>(resultShares);

                    GamesAndSharesViewModel viewModel = new GamesAndSharesViewModel
                    {
                        Games = modelGames,
                        Shares = modelShares
                    };

                    return View(viewModel);
                }
                return RedirectToAction("ErrorPage", "RedirectStatusCode");
            }
        }
        public async Task<IActionResult> Shares() 
        {
            using (var httpClient = new HttpClient())
            {
                //httpClient.BaseAddress = new Uri("https://localhost:7296");
                var responseGetGames = await httpClient.GetAsync("https://localhost:7296/api/produts/games");
                var responseGetShares = await httpClient.GetAsync("https://localhost:7296/api/shares/shares");
                if (responseGetGames.IsSuccessStatusCode && responseGetShares.IsSuccessStatusCode)
                {
                    var resultGames = await responseGetGames.Content.ReadAsStringAsync();
                    var resultShares = await responseGetGames.Content.ReadAsStringAsync();
                    List<GamesModel>? modelGames = JsonConvert.DeserializeObject<List<GamesModel>>(resultGames);
                    List<SharesModel>? modelShares = JsonConvert.DeserializeObject<List<SharesModel>>(resultShares);

                    GamesAndSharesViewModel viewModel = new GamesAndSharesViewModel
                    {
                        Games = modelGames,
                        Shares = modelShares
                    };

                    return View(viewModel);
                }
                return RedirectToAction("ErrorPage", "RedirectStatusCode");
            }
        }
        public IActionResult Support() 
        {
            return View();
        }
        [HttpGet]
        public async Task <IActionResult> SinglePageGame(int Id)
        {
            using (var httpClient = new HttpClient())
            {
                var responseGetGamesId = await httpClient.GetAsync("https://localhost:7296/api/produts/games/"+ Id);
                var responseGetSharesId = await httpClient.GetAsync("https://localhost:7296/api/shares/shares/" + Id);
                if (responseGetGamesId.IsSuccessStatusCode && responseGetSharesId.IsSuccessStatusCode)
                {
                    var resultGames = await responseGetGamesId.Content.ReadAsStringAsync();
                    var resultShares = await responseGetSharesId.Content.ReadAsStringAsync();

                    GamesModel modelGames = JsonConvert.DeserializeObject<GamesModel>(resultGames);
                    SharesModel modelShares = JsonConvert.DeserializeObject<SharesModel>(resultShares);

                    GamesAndSharesViewModel viewModel = new GamesAndSharesViewModel
                    {
                        Game = modelGames,
                        Share = modelShares
                    };

                    return View(viewModel);
                }
            }
            return RedirectToAction("ErrorPage", "RedirectStatusCode");
        }
    }
}