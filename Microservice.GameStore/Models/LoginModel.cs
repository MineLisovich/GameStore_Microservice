using System.ComponentModel.DataAnnotations;

namespace Microservice.GameStore.Models
{
    public class LoginModel
    {
        [Required]
        public string Login { get; set;}
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set;}
    }
}
