using Microservice.GameStore.Models;

namespace Microservice.GameStore.ViewModels
{
    public class GamesAndSharesViewModel
    {
        public IEnumerable<GamesModel> Games { get; set; }
        public IEnumerable<SharesModel> Shares { get; set; }

        public GamesModel Game { get; set; }
        public SharesModel Share { get; set; }
    }
}
