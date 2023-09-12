using Microservice.Products.Data.Entities;

namespace Microservice.Products.Data.Repositories.Abstract
{
    public interface IGames
    {
        Task<IEnumerable<Games>> GetAllAsync();
        Task<Games> GetByIdAsync(int id);
        Task<Games> GetByNameAsync(string name);
        Task SaveAsync(Games entity);
        Task DeleteAsync(int id);
    }
}
