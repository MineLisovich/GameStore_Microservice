using Microservice.Products.Data.Entities;
using Microservice.Products.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Products.Data.Repositories.EntityFramework
{
    public class EFShares : IShares
    {
        private readonly ProductsDbContext _context;

        public EFShares(ProductsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Shares>> GetAllAsync()
        {
           
            return await _context.Shares.Include(g => g.Games).ToListAsync();
        }
        public async Task<Shares> GetByIdAsync(int id)
        {
            Shares result = await _context.Shares.Include(g => g.Games).FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task SaveAsync(Shares entity)
        {
            if (entity.Id == default)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                _context.Entry(entity).State = EntityState.Modified;

            }
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _context.Shares.Remove(new Shares() { Id = id });
            await _context.SaveChangesAsync();
        }
    }
}
