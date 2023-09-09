using Microsoft.EntityFrameworkCore;

namespace Microservice.Authorization.Data.Repositories
{
    public class EFUsersRepository : IUsersRepository
    {
        private readonly AuthDbContext _dbContext;
        public EFUsersRepository(AuthDbContext dbContext) { _dbContext = dbContext; }

        public async Task <IEnumerable<Users>> GetUsersListAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public Users FindByLoginPassword (string login, string password)
        {
            return  _dbContext.Users.FirstOrDefault(user => user.Login == login && user.Password == password);
        }
        public void Save(Users entity)
        {
            if (entity.Id == default)
            {
                _dbContext.Entry(entity).State = EntityState.Added;
            }
            else
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
            }
            _dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            _dbContext.Users.Remove(new Users() { Id = id });
            _dbContext.SaveChanges();
        }
    }
}
