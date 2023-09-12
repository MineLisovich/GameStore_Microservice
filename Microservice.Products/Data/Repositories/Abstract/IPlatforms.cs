using Microservice.Products.Data.Entities;

namespace Microservice.Products.Data.Repositories.Abstract
{
    public interface IPlatforms
    {
        Task<IQueryable<Platforms>> GetAllAsync();
        Task<Platforms> GetByIdAsync(int id);
        Task<Platforms> GetByNameAsync(string name);
        Task SaveAsync(Platforms entity);
        Task DeleteAsync(int id);
    }
}
