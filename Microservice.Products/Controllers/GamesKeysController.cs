using Microservice.Products.Data.Entities;
using Microservice.Products.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Microservice.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class GamesKeysController : ControllerBase
    {
        private readonly DataManager _dataManager;
        public GamesKeysController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet]
        [Route("getgamekeys")]
        public async Task<IEnumerable<GamesKeys>> GetGameKey()
        {
            IEnumerable<GamesKeys> result = await _dataManager.GamesKeys.GetAllAsync();

            if (result != null)
            {
                return result;
            }
            return null;
        }
    }
}
