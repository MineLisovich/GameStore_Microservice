using System.ComponentModel.DataAnnotations;

namespace Microservice.GameStore.Data
{
    public class Users
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Login { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? Role { get; set; }
    }
}
