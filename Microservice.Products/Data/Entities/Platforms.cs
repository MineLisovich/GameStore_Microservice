using System.ComponentModel.DataAnnotations;

namespace Microservice.Products.Data.Entities
{
    public class Platforms
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите Наименование платформы")]
        public string NamePlatform { get; set; }
    }
}
