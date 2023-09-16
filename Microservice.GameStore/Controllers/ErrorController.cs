using Microsoft.AspNetCore.Mvc;

namespace Microservice.GameStore.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult ErorrPage()
        {
            return View();
        }
    }
}
