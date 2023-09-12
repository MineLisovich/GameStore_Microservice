using Microservice.GameStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.GameStore.Areas.User.Controllers
{
    [Area(UserRolesList.User)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
