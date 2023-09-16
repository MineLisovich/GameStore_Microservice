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
                return RedirectToAction("ErrorPage", "Error");
            }   
        }
        public IActionResult Catalog()
        {
            return View();
        }
        public IActionResult Shares() 
        {  
            return View();
        }
        public IActionResult Support() 
        {
            return View();
        }
        public IActionResult SinglePageGame()
        {
            return View();
        }
    }
}