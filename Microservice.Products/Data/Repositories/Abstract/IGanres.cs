using Microservice.Products.Data.Entities;

namespace Microservice.Products.Data.Repositories.Abstract
{
    public interface IGanres
    {
        Task<IQueryable<Ganres>> GetAllAsync();
        Task<Ganres> GetByIdAsync(int id);
        Task<Ganres> GetByNameAsync(string name);
        Task SaveAsync(Ganres entity);
        Task DeleteAsync(int id);
    }
}
