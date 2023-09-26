using Microservice.GameStore.Data;
using Microservice.GameStore.Models;
using Microservice.GameStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Microservice.GameStore.Areas.Admin.Controllers
{
    [Area(UserRolesList.Admin)]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Games()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:7296");
                var response = await httpClient.GetAsync("/api/produts/games");

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    List<GamesModel>? model = JsonConvert.DeserializeObject<List<GamesModel>>(result);

                    GamesAndSharesViewModel viewModel = new GamesAndSharesViewModel
                    {
                        Games = model
                    };

                    return View(viewModel);
                }
                return RedirectToAction("ErrorPage", "RedirectStatusCode");
            }
        }
        [HttpGet]
        public async Task<IActionResult> GameKey()
        {
            var token = HttpContext.Request.Cookies["GemeStoreCookie"];
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:7296");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync("/api/GamesKeys/getgamekeys");

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    List<GamesKeysModel>? model = JsonConvert.DeserializeObject<List<GamesKeysModel>>(result);

                    GamesKeysViewModel viewModel = new GamesKeysViewModel
                    {
                        GamesKeys = model
                    };

                    return View(viewModel);
                }
                return RedirectToAction("ErrorPage", "RedirectStatusCode");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Shares()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:7296");
                var response = await httpClient.GetAsync("/api/shares/shares");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    List<SharesModel>? model = JsonConvert.DeserializeObject<List<SharesModel>>(result);

                    GamesAndSharesViewModel viewModel = new GamesAndSharesViewModel
                    {
                        Shares = model
                    };
                    return View(viewModel);
                }
                return RedirectToAction("ErrorPage", "RedirectStatusCode");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Developers()
        {
            var token = HttpContext.Request.Cookies["GemeStoreCookie"];
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:7296");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync("/api/Developers/developers");

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    List<DevelopersModel>? model = JsonConvert.DeserializeObject<List<DevelopersModel>>(result);

                    DevelopersViewModel viewModel = new DevelopersViewModel
                    {
                        Developers = model
                    };

                    return View(viewModel);
                }
                return RedirectToAction("ErrorPage", "RedirectStatusCode");
            }
        }
    }
}
