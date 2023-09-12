using Microservice.GameStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.GameStore.Areas.Admin.Controllers
{
    [Area(UserRolesList.Admin)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
