using CarDealer.Domain.Interface.Repository;
using CarDealer.Domain.Interface.Service;
using CarDealer.Domain.Model;
using CarDealer.Domain.Service.Base;

namespace CarDealer.Domain.Service
{
    public class UserService : BaseService<User, IUserRepository>, IUserService
    {
        public UserService(IUserRepository repository) : base(repository)
        {
        }

        public async Task<User> GetByName(string name)
        {
            return await _repository.GetByName(name);
        }

    }
}
