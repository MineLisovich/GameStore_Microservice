using Microservice.Products.Data.Entities;
using System.Security.Cryptography;

namespace Microservice.Products.Data.Predefineds
{
    public class PredefinedShares
    {
        Shares id1 = new()
        {
            Id = 701,
            Gamesid = 401,
            DiscountPrice = 30,
            NameImageSlider = "2077.png"
        };
        Shares id2 = new()
        {
            Id = 702,
            Gamesid = 405,
            DiscountPrice = 55,
            NameImageSlider = "Fallout76.png"
        };
        Shares id3 = new()
        {
            Id = 703,
            Gamesid = 408,
            DiscountPrice = 70,
            NameImageSlider = "rdr2.png"
        };
        Shares id4 = new()
        {
            Id = 704,
            Gamesid = 407,
            DiscountPrice = 30,
            NameImageSlider = "Wicher3.png"
        };
        public List<Shares> _gamesList;
        public PredefinedShares()
        {
            _gamesList = new()
            {
              id1, id2, id3, id4
            };
        }
    }
}
