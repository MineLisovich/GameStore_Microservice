using Microservice.Products.Data;
using Microservice.Products.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        private readonly DataManager _dataManager;
        public PlatformsController (DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpGet]
        [Route("platfroms")]
        public async Task<IEnumerable<Platforms>> GetPlatforms()
        {
            IEnumerable<Platforms> result = await _dataManager.Platforms.GetAllAsync();
            return result;
        }
    }
}
