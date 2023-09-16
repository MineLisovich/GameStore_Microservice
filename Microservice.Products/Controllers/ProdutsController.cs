using Microservice.Products.Data;
using Microservice.Products.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutsController : ControllerBase
    {
        private readonly DataManager _dataManager;
        public ProdutsController (DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpGet]
        [Route("games")]
        public async Task <IEnumerable<Games>> GetGames()
        {
            IEnumerable<Games> result =  await _dataManager.Games.GetAllAsync();
            return result;
        }

        //ALL TEST METHODS
        [HttpGet]
        [Route("developers")]
        public async Task<IEnumerable<Developers>> GetDev()
        {
            IEnumerable<Developers> result = await _dataManager.Developers.GetAllAsync();
            return result;
        }
        [HttpGet]
        [Route("testgamekeys")]
        public async Task<IEnumerable<GamesKeys>> GetGameKey()
        {
            IEnumerable<GamesKeys> result = await _dataManager.GamesKeys.GetAllAsync();
            return result;
        }
        [HttpGet]
        [Route("ganres")]
        public async Task<IEnumerable<Ganres>> GetGanres()
        {
            IEnumerable<Ganres> result = await _dataManager.Ganres.GetAllAsync();
            return result;
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
