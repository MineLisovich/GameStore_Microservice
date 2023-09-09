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
    }
}