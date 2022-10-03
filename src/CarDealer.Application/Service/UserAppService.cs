using AutoMapper;
using CarDealer.Application.Interface;
using CarDealer.Application.ViewModel;
using CarDealer.Domain.Interface.Service;
using CarDealer.Domain.Model;

namespace CarDealer.Application.Service
{
    public class UserAppService : IUserAppService
    {
        protected readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserAppService(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<int> Delete(UserViewModel user)
        {
            return await _userService.Delete(_mapper.Map<User>(user));
        }

        public async Task<UserViewModel> GetByName(string name)
        {
            return  _mapper.Map<UserViewModel>(await _userService.GetByName(name));
        }

        public async Task<int> Insert(UserViewModel user)
        {
            return await _userService.Insert(_mapper.Map<User>(user));
        }

        public async Task<int> Update(UserViewModel user)
        {
            return await _userService.Update(_mapper.Map<User>(user));
        }
    }
}
