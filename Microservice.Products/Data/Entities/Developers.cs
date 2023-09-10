using System.ComponentModel.DataAnnotations;

namespace Microservice.Products.Data.Entities
{
    public class Developers
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string NameDeveloper { get; set; }
    }
}
