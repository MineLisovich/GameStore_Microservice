using Microsoft.EntityFrameworkCore;

namespace Microservice.GameStore.Models
{
    public class GamesModel
    {
        public int Id { get; set; }
        public string NameGame { get; set; }
        public string DescriptionG { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Precision(10, 2)]
        public decimal Price { get; set; }
        public string Poster { get; set; }
        public DateTime DateAddedSite { get; set; }
        public string ScreenshotGame1 { get; set; }
        public string ScreenshotGame2 { get; set; }
        public string ScreenshotGame3 { get; set; }
        public string ScreenshotGame4 { get; set; }
        public string LinkTrailerGame { get; set; }
        public string OS { get; set; } 
        public string CPU { get; set; } 
        public int RAM { get; set; }
        public string VRAM { get; set; }    
        public int GameWeight { get; set; }
        public string Features { get; set; }

        // связи с другими таблицами
        public GanresModel Ganres { get; set; }
        public int Ganresid { get; set; }
        public DevelopersModel Developers { get; set; }
        public int Developersid { get; set; }
        public PlatformsModel Platforms { get; set; }
        public int Platformsid { get; set; }
    }
}
