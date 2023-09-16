using Microsoft.EntityFrameworkCore;

namespace Microservice.GameStore.Models
{
    public class SharesModel
    {
        
        public int Id { get; set; }

        [Precision(10, 2)]
        public decimal DiscountPrice { get; set; }
        public string NameImageSlider { get; set; }
        // связи с другими таблицами
        public GamesModel Games { get; set; }
        public int Gamesid { get; set; }
    }
}
