namespace Microservice.GameStore.Models
{
    public class GamesKeysModel
    {
        public int Id { get; set; }      
        public string Key_game { get; set; }
        public GamesModel Games { get; set; }
        public int Gamesid { get; set; }
    }
}
