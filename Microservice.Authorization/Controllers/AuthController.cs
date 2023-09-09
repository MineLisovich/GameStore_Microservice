using Microservice.Authorization.Data;
using Microservice.Authorization.Data.Repositories;
using Microservice.Authorization.Models;
using Microservice.Authorization.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Microservice.Authorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;
        public AuthController(IUsersRepository usersRepository) { _usersRepository = usersRepository; }


        [HttpGet]
        [Route("getuser")]
        public async Task <IEnumerable<Users>> GetUsers()
        {
            IEnumerable<Users> users = await _usersRepository.GetUsersListAsync();
            return users;
        }
        [HttpPost]
        [Route("login")]
        public  IResult Login([FromBody] LoginModel model)
        {
            var identity =  GetIdentity(model.Login, model.Password);
            if (identity == null)
            {
                return Results.NotFound(new { message = "Неверный логин или пароль" });
            }

            var date_time = DateTime.UtcNow;

            // Создаём JWT token
            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                notBefore: date_time,
                claims: identity.Claims,
                expires: date_time.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

       

            HttpContext.Response.Cookies.Append("GemeStoreCookie", encodedJwt,
              new CookieOptions
              {
                  MaxAge = TimeSpan.FromMinutes(120)
              });

            return Results.Json(encodedJwt);
        }
        private ClaimsIdentity GetIdentity(string login, string password)
        {
            Users user = _usersRepository.FindByLoginPassword(login, password);
            if (user != null)
            {
                // определяем какие данные будут храниться в jwt токене
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
                };
                ClaimsIdentity claimsIdentity =
                    new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            return null;
        }

        [HttpPost]
        [Route("registration")]
        public IResult Registration (RegistrationModel model)
        {
            Users usermodel = new Users();
            if (model.Login != null && model.Password !=null && model.Email != null)
            {
                usermodel.Login = model.Login;
                usermodel.Password = model.Password;
                usermodel.Email = model.Email;
                usermodel.Role = "User";
                _usersRepository.Save(usermodel);
                return Results.Json(usermodel); 
            }
            return Results.NotFound(new { message = "Заполните поля" });  
        }
        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("GemeStoreCookie",
             new CookieOptions
             {
                 Expires = DateTime.Now.AddDays(-10)
             });
            return Ok();
        }
    
    }
}
