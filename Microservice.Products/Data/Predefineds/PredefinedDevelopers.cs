using Microservice.Products.Data.Entities;

namespace Microservice.Products.Data.Predefineds
{
    public class PredefinedDevelopers
    {
        Developers id1 = new()
        {
            Id = 101,
            NameDeveloper = "Bethesda"
        };
        Developers id2 = new()
        {
            Id = 102,
            NameDeveloper = "Blizzard"
        };
        Developers id3 = new()
        {
            Id = 103,
            NameDeveloper = "Valve"
        };
        Developers id4 = new()
        {
            Id = 104,
            NameDeveloper = "Electronic Arts"
        };
        Developers id5 = new()
        {
            Id = 105,
            NameDeveloper = "RockStar Games"
        };
        Developers id6 = new()
        {
            Id = 106,
            NameDeveloper = "Ubisoft"
        };
        Developers id7 = new()
        {
            Id = 107,
            NameDeveloper = "Square Enix"
        };
        Developers id8 = new()
        {
            Id = 108,
            NameDeveloper = "Activision"
        };
        Developers id9 = new()
        {
            Id = 109,
            NameDeveloper = "Konami"
        };
        Developers id10 = new()
        {
            Id = 110,
            NameDeveloper = "2K Games"
        };
        Developers id11 = new()
        {
            Id = 111,
            NameDeveloper = "Matrix Games"
        };
        Developers id12 = new()
        {
            Id = 112,
            NameDeveloper = "Nacon"
        };
        Developers id13 = new()
        {
            Id = 113,
            NameDeveloper = "Majesco"
        };
        Developers id14 = new()
        {
            Id = 114,
            NameDeveloper = "CD Projekt Red"
        };
        Developers id15 = new()
        {
            Id = 115,
            NameDeveloper = "Iron Gate AB"
        };

        public List<Developers> _developersList;
        public PredefinedDevelopers()
        {
            _developersList = new()
            {
              id1, id2, id3, id4, id5, id6, id7, id8, id9, id10, id11, id12, id13,id14,id15
            };
        }
    }
}
