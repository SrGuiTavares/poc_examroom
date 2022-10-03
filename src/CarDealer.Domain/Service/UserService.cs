using CarDealer.Domain.Interface.Repository;
using CarDealer.Domain.Interface.Service;
using CarDealer.Domain.Model;

namespace CarDealer.Domain.Service
{
    public class UserService : IUserService
    {
        protected readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Delete(User user)
        {
            return await _userRepository.Delete(user);
        }

        public async Task<User> GetByName(string name)
        {
            return await _userRepository.GetByName(name);
        }

        public async Task<int> Insert(User user)
        {



            return await _userRepository.Insert(user);
        }

        public async Task<int> Update(User user)
        {
            return await _userRepository.Update(user);
        }
    }
}
