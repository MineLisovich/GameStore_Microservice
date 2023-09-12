using Microservice.Products.Data.Entities;

namespace Microservice.Products.Data.Repositories.Abstract
{
    public interface IDevelopers
    {
        Task<IQueryable<Developers>> GetAllAsync();
        Task<Developers> GetByIdAsync(int id);
        Task<Developers> GetByNameAsync(string name);
        Task SaveAsync(Developers entity);
        Task DeleteAsync(int id);
    }
}
