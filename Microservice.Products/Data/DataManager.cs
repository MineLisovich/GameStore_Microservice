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



        public DataManager(IGames Games, IDevelopers Developers,
            IGanres Ganres, IPlatforms Platforms, IShares Shares,
            IGamesKeys GamesKeys)
        {
            this.Games = Games;
            this.Developers = Developers;
            this.Ganres = Ganres;   
            this.Platforms = Platforms; 
            this.Shares = Shares;
            this.GamesKeys = GamesKeys;
        }
    }
}
