using CarDealer.Domain.Model;

namespace CarDealer.Domain.Interface.Repository
{
    public interface IUserRepository
    {
        Task<int> Insert(User user);
        Task<int> Update(User user);
        Task<int> Delete(User user);
        Task<User> GetByName(string name);
    }
}
