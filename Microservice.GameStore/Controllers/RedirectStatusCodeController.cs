using Microsoft.AspNetCore.Mvc;

namespace Microservice.GameStore.Controllers
{
    public class RedirectStatusCodeController : Controller
    {
        [HttpGet]
        public IActionResult Forbidden()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ErrorPage()
        {
            return View();
        }
    }
}
