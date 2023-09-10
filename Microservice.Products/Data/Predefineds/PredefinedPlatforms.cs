using Microservice.Products.Data.Entities;

namespace Microservice.Products.Data.Predefineds
{
    public class PredefinedPlatforms
    {
        Platforms id1 = new()
        {
            Id = 301,
            NamePlatform = "Steam"
        };
        Platforms id2 = new()
        {
            Id = 302,
            NamePlatform = "Origin"
        };
        Platforms id3 = new()
        {
            Id = 303,
            NamePlatform = "Battle.net"
        };
        Platforms id4 = new()
        {
            Id = 304,
            NamePlatform = "RockStar Launcher"
        };
        Platforms id5 = new()
        {
            Id = 305,
            NamePlatform = "Epic Games Launcher"
        };
        Platforms id6 = new()
        {
            Id = 306,
            NamePlatform = "Ubisoft Connect"
        };
 

        public List<Platforms> _platformsList;
        public PredefinedPlatforms()
        {
            _platformsList = new()
            {
              id1, id2, id3, id4, id5, id6
            };
        }
    }
}
