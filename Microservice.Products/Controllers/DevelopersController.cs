using Microservice.Products.Data.Entities;
using Microservice.Products.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Microservice.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class DevelopersController : ControllerBase
    {
        private readonly DataManager _dataManager;
        public DevelopersController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet]
        [Route("developers")]
        public async Task<IEnumerable<Developers>> GetDev()
        {
            IEnumerable<Developers> result = await _dataManager.Developers.GetAllAsync();
            if (result != null)
            {
                return result;
            }

            return null;
        }
    }
}
