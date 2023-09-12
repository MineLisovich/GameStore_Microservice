using Microservice.Products.Data.Entities;

namespace Microservice.Products.Data.Repositories.Abstract
{
    public interface IGamesKeys
    {
        Task<IEnumerable<GamesKeys>> GetAllAsync();
        Task<GamesKeys> GetByIdAsync(int id);
        Task<GamesKeys> GetByNameAsync(string name);
        Task SaveAsync(GamesKeys entity);
        Task DeleteAsync(int id);
    }
}
