using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Microservice.Products.Data.Entities
{
    public class Games
    {

        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите Наименование игры")]
        public string NameGame { get; set; }
        [Required(ErrorMessage = "Введите Описаниае игры")]
        public string DescriptionG { get; set; }
        [Required(ErrorMessage = "Введите Дату выхода игры")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Введите Стоимость игры")]
        [Precision(10, 2)]
        public decimal Price { get; set; }
        public string Poster { get; set; }
        [Required]
        public DateTime DateAddedSite { get; set; }
        public string ScreenshotGame1 { get; set; }
        public string ScreenshotGame2 { get; set; }
        public string ScreenshotGame3 { get; set; }
        public string ScreenshotGame4 { get; set; }
        public string LinkTrailerGame { get; set; }
        [Required(ErrorMessage = "Введите рекомендуемую ОС")]
        public string OS { get; set; }
        [Required(ErrorMessage = "Введите рекомендуемый процессор CPU")]
        public string CPU { get; set; }
        [Required(ErrorMessage = "Введите рекомендуемое количество памяти ОЗУ")]
        public int RAM { get; set; }

        [Required(ErrorMessage = "Введите рекомендуемую видеокарту")]
        public string VRAM { get; set; }

        [Required(ErrorMessage = "Введите сколько будет занимать игра место на диске")]
        public int GameWeight { get; set; }

        [Required(ErrorMessage = "Введите особенности игры (одиночная игра, кооп, и тд...)")]
        public string Features { get; set; }

        // связи с другими таблицами
        public Ganres Ganres { get; set; }
        public int Ganresid { get; set; }
        public Developers Developers { get; set; }
        public int Developersid { get; set; }
        public Platforms Platforms { get; set; }
        public int Platformsid { get; set; }
    }
}
