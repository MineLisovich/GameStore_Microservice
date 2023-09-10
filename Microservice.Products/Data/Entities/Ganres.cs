using System.ComponentModel.DataAnnotations;

namespace Microservice.Products.Data.Entities
{
    public class Ganres
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите Наименование жанра")]
        public string NameGanres { get; set; }
        public ICollection<Games> GanresGames { get; set; }
        public Ganres()
        {

            GanresGames = new List<Games>();
        }
    }
}
