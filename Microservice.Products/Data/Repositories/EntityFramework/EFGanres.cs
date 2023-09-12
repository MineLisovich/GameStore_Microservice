using Microservice.Products.Data.Entities;
using Microservice.Products.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Products.Data.Repositories.EntityFramework
{
    public class EFGanres : IGanres
    {
        private readonly ProductsDbContext _context;

        public EFGanres(ProductsDbContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<Ganres>> GetAllAsync()
        {
            IQueryable<Ganres> result = (IQueryable<Ganres>)await _context.Ganres.ToListAsync();
            return result;
        }
        public async Task<Ganres> GetByIdAsync(int id)
        {
            Ganres result = await _context.Ganres.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
        public async Task<Ganres> GetByNameAsync(string name)
        {
            Ganres result = await _context.Ganres.FirstOrDefaultAsync(x => x.NameGanres == name);
            return result;
        }

        public async Task SaveAsync(Ganres entity)
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
            _context.Ganres.Remove(new Ganres() { Id = id });
            await _context.SaveChangesAsync();
        }
    }
}
