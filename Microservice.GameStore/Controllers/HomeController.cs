using Microservice.GameStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Microservice.GameStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        public async Task<JsonResult> Test()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri($"https://localhost:7254");
                var response = await httpClient.GetAsync("/api/Test/test");

                if (response.IsSuccessStatusCode)
                {

                    var result = await response.Content.ReadAsStringAsync();

                    var final_result = "Это сообщение было получено с микросервиса User: " + result;
                    return Json(final_result);
                }
                else
                {
                    return null;
                }

            }
        }
    }
}