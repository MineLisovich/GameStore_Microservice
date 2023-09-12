using Microservice.Products.Data.Entities;
using Microservice.Products.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Products.Data.Repositories.EntityFramework
{
    public class EFGamesKeys : IGamesKeys
    {
        private readonly ProductsDbContext _context;

        public EFGamesKeys(ProductsDbContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<GamesKeys>> GetAllAsync()
        {
            IQueryable<GamesKeys> result = (IQueryable<GamesKeys>)await _context.GamesKeys.Include(g=>g.Games).ToListAsync();
            return result;
        }
        public async Task<GamesKeys> GetByIdAsync(int id)
        {
            GamesKeys result = await _context.GamesKeys.Include(g => g.Games).FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
        public async Task<GamesKeys> GetByNameAsync(string name)
        {
            GamesKeys result = await _context.GamesKeys.Include(g => g.Games).FirstOrDefaultAsync(x => x.Key_game == name);
            return result;
        }

        public async Task SaveAsync(GamesKeys entity)
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
            _context.GamesKeys.Remove(new GamesKeys() { Id = id });
            await _context.SaveChangesAsync();
        }
    }
}
