using CarDealer.Domain.Interface.Service.Base;
using CarDealer.Domain.Model;

namespace CarDealer.Domain.Interface.Service
{
    public interface IUserService : IBaseService<User>
    {
        Task<User> GetByName(string name);
    }
}
