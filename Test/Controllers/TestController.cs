using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TestController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("test")]
        public IResult Test()
        {
            var test = "eee";
            return Results.Ok(test);
        }
    }
}
