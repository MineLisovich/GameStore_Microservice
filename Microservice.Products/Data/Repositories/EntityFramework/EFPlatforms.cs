using Microservice.Products.Data.Entities;
using Microservice.Products.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Products.Data.Repositories.EntityFramework
{
    public class EFPlatforms : IPlatforms
    {
        private readonly ProductsDbContext _context;

        public EFPlatforms(ProductsDbContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<Platforms>> GetAllAsync()
        {
            IQueryable<Platforms> result = (IQueryable<Platforms>)await _context.Platforms.ToListAsync();
            return result;
        }
        public async Task<Platforms> GetByIdAsync(int id)
        {
            Platforms result = await _context.Platforms.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
        public async Task<Platforms> GetByNameAsync(string name)
        {
            Platforms result = await _context.Platforms.FirstOrDefaultAsync(x => x.NamePlatform == name);
            return result;
        }

        public async Task SaveAsync(Platforms entity)
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
            _context.Platforms.Remove(new Platforms() { Id = id });
            await _context.SaveChangesAsync();
        }
    }
}
