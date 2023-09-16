namespace Microservice.GameStore.Models
{
    public class GanresModel
    {
       
        public int Id { get; set; }
        public string NameGanres { get; set; }
        public ICollection<GamesModel> GanresGames { get; set; }
        public GanresModel()
        {
            GanresGames = new List<GamesModel>();
        }
    }
}
