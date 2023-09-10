using System.ComponentModel.DataAnnotations;

namespace Microservice.Products.Data.Entities
{
    public class GamesKeys
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите Ключ от игры")]
        public string Key_game { get; set; }
        public Games Games { get; set; }
        public int Gamesid { get; set; }     
    }
}
