using CarDealer.Domain.Interface.Repository.Base;
using CarDealer.Domain.Model;

namespace CarDealer.Domain.Interface.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByName(string name);
    }
}
