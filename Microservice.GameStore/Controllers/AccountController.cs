using Microservice.GameStore.Data;
using Microservice.GameStore.Data.Repositories;
using Microservice.GameStore.Models;
using Microservice.GameStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace Microservice.GameStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUsersRepository _usersRepository;
        public AccountController(IUsersRepository usersRepository) { _usersRepository = usersRepository; }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult Login ( LoginModel model)
        {
            var identity = GetIdentity(model.Login, model.Password);
            if (identity == null)
            {
                return View(model);
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
            return RedirectToAction("Index", "Home");
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
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(RegistrationModel model)
        {
            Users usermodel = new Users();
            if (model.Login != null && model.Password != null && model.Email != null)
            {
                usermodel.Login = model.Login;
                usermodel.Password = model.Password;
                usermodel.Email = model.Email;
                usermodel.Role = "User";
                _usersRepository.Save(usermodel);
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("GemeStoreCookie",
             new CookieOptions
             {
                 Expires = DateTime.Now.AddDays(-10)
             });
            return RedirectToAction("Index", "Home");
        }



    }
}
