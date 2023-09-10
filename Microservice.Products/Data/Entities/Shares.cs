using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Microservice.Products.Data.Entities
{
    public class Shares
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите новую цену")]
        [Precision(10, 2)]
        public decimal DiscountPrice { get; set; }

        [Required(ErrorMessage = "Введите имя картинки")]
        public string NameImageSlider { get; set; }
        // связи с другими таблицами
        public Games Games { get; set; }
        public int Gamesid { get; set; }
    }
}
