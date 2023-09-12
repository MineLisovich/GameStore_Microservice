using System.ComponentModel.DataAnnotations;

namespace Microservice.GameStore.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
