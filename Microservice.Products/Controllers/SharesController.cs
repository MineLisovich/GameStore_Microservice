﻿using Microservice.Products.Data;
using Microservice.Products.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharesController : ControllerBase
    {
        private readonly DataManager _dataManager;
        public SharesController (DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpGet]
        [Route("shares")]
        public async Task<IEnumerable<Shares>> GetShares()
        {
            IEnumerable<Shares> result = await _dataManager.Shares.GetAllAsync();
            return result;
        }
    }
}
