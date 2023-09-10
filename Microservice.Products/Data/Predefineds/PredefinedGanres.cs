using Microservice.Products.Data.Entities;

namespace Microservice.Products.Data.Predefineds
{
    public class PredefinedGanres
    {
        Ganres id1 = new()
        {
            Id= 201,
            NameGanres = "Экшн"
        };
        Ganres id2 = new()
        {
            Id = 202,
            NameGanres = "Приключения"
        };
        Ganres id3 = new()
        {
            Id = 203,
            NameGanres = "RPG"
        };
        Ganres id4 = new()
        {
            Id = 204,
            NameGanres = "Симуляторы"
        };
        Ganres id5 = new()
        {
            Id = 205,
            NameGanres = "Спорт"
        };
        Ganres id6 = new()
        {
            Id = 206,
            NameGanres = "Гонки"
        };
        Ganres id7 = new()
        {
            Id = 207,
            NameGanres = "Казуал"
        };

        public List<Ganres> _ganresList;
        public PredefinedGanres()
        {
            _ganresList = new()
            {
              id1, id2, id3, id4, id5, id6, id7
            };
        }
    }
}
