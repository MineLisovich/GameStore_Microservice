namespace Microservice.GameStore.Data.Repositories
{
    public interface IUsersRepository
    {
      Task <IEnumerable<Users>> GetUsersListAsync();
      Users FindByLoginPassword(string login, string password);
      void Save(Users entity);
      void Delete(int id);
    }
}
