using Microservice.Products.Data.Entities;
using Microservice.Products.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Products.Data.Repositories.EntityFramework
{
    public class EFDevelopers : IDevelopers
    {
        private readonly ProductsDbContext _context;

        public EFDevelopers(ProductsDbContext context)
        {
            _context = context;
        }

        public async Task <IEnumerable<Developers>> GetAllAsync()
        {
           return await _context.Developers.ToListAsync();
        }
        public async Task<Developers> GetByIdAsync (int id)
        {
            Developers result = await _context.Developers.FirstOrDefaultAsync (x => x.Id == id);
            return result;
        }
        public async Task<Developers> GetByNameAsync (string name)
        {
            Developers result = await _context.Developers.FirstOrDefaultAsync(x => x.NameDeveloper == name);
            return result;
        }

        public async Task SaveAsync (Developers entity)
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

        public async Task DeleteAsync (int id)
        {
            _context.Developers.Remove(new Developers() { Id = id });
            await _context.SaveChangesAsync();
        }
    }
}
