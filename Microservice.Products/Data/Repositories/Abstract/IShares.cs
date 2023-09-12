using Microservice.Products.Data.Entities;

namespace Microservice.Products.Data.Repositories.Abstract
{
    public interface IShares
    {
        Task<IQueryable<Shares>> GetAllAsync();
        Task<Shares> GetByIdAsync(int id);
        Task SaveAsync(Shares entity);
        Task DeleteAsync(int id);
    }
}
