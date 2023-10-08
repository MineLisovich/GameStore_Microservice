using Microservice.Products.Data;
using Microservice.Products.Data.Entities;
using Microservice.Products.Models;
using Microsoft.AspNetCore.Diagnostics;
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
            if (result != null)
            {
                return result;
            }

            return null;
        }
        [HttpGet]
        [Route("games/{Id}")]
        public async Task <Games> GetGamesById(int Id)
        {
            Games result = await _dataManager.Games.GetByIdAsync(Id);
            if (result != null)
            {
                return result;
            }

            return null;
        }
    }
}
