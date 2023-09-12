using Microservice.Products.Data.Entities;
using Microservice.Products.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Products.Data.Repositories.EntityFramework
{
    public class EFGames : IGames
    {
        private readonly ProductsDbContext _context;

        public EFGames(ProductsDbContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<Games>> GetAllAsync()
        {
            IQueryable<Games> result = (IQueryable<Games>)await _context.Games.Include(d=>d.Developers)
                                                                               .Include(g=>g.Ganres)
                                                                               .Include(p=>p.Platforms).ToListAsync();
            return result;
        }
        public async Task<Games> GetByIdAsync(int id)
        {
            Games result = await _context.Games.Include(d => d.Developers)
                                               .Include(g => g.Ganres)
                                               .Include(p => p.Platforms)
                                               .FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
        public async Task<Games> GetByNameAsync(string name)
        {
            Games result = await _context.Games.Include(d => d.Developers)
                                               .Include(g => g.Ganres)
                                               .Include(p => p.Platforms)
                                               .FirstOrDefaultAsync(x => x.NameGame == name); ;
            return result;
        }

        public async Task SaveAsync(Games entity)
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
            _context.Games.Remove(new Games() { Id = id });
            await _context.SaveChangesAsync();
        }
    }
}
