using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Test.Services
{
    public class AuthOptions
    {
        /// <summary>
        /// Создатель токена
        /// </summary>
        public const string ISSUER = "Microservice.Authorization";
        /// <summary>
        /// Потребитель токена
        /// </summary>
        public const string AUDIENCE = "AuthClient";
        /// <summary>
        /// Секретный ключ для кодирования
        /// </summary>
        const string KEY = "RFHRu27362HFERIUYsdfnmUUUS2323BBDBD";
        /// <summary>
        /// Время жизни токена (в минутах)
        /// </summary>
        public const int LIFETIME = 120;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
