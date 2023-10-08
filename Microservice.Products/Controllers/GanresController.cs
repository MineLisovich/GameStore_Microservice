using Microservice.Products.Data.Entities;
using Microservice.Products.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GanresController : ControllerBase
    {
        private readonly DataManager _dataManager;
        public GanresController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet]
        [Route("ganres")]
        public async Task<IEnumerable<Ganres>> GetGanres()
        {
            IEnumerable<Ganres> result = await _dataManager.Ganres.GetAllAsync();
            return result;
        }
    }
}
