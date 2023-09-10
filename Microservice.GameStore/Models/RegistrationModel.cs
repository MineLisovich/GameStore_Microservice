using System.ComponentModel.DataAnnotations;

namespace Microservice.GameStore.Models
{
    public class RegistrationModel
    {
        [Required]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
