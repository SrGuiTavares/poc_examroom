using CarDealer.Domain.Model;

namespace CarDealer.Domain.Interface.Service
{
    public interface IUserService
    {
        Task<int> Insert(User user);
        Task<int> Update(User user);
        Task<int> Delete(User user);
        Task<User> GetByName(string name);
    }
}
