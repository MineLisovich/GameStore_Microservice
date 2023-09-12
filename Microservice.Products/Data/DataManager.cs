using Microservice.Products.Data.Repositories.Abstract;

namespace Microservice.Products.Data
{
    public class DataManager
    {
        public IGames Games { get; set; }
        public IDevelopers Developers { get; set; }
        public IGanres Ganres { get; set; }
        public IPlatforms Platforms { get; set; }
        public IShares Shares { get; set; }
        public IGamesKeys GamesKeys { get; set; }

    

        public DataManager(IGames _Games, IDevelopers _Developers,
            IGanres _Ganres, IPlatforms _Platforms, IShares _Shares,
            IGamesKeys _GamesKeys)
        {
            Games = _Games;
            Developers = _Developers;
            Ganres = _Ganres;
            Platforms = _Platforms;
            Shares = _Shares;
            GamesKeys = _GamesKeys;

        }
    }
}
