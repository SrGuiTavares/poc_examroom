using AutoMapper;
using CarDealer.Application.Interface;
using CarDealer.Application.Service.Base;
using CarDealer.Application.ViewModel;
using CarDealer.Domain.Interface.Service;
using CarDealer.Domain.Model;

namespace CarDealer.Application.Service
{
    public class UserAppService : BaseService<User, UserViewModel, IUserService>, IUserAppService
    {

        public UserAppService(IUserService _domainService, IMapper _mapper) : base(_domainService, _mapper)
        {
        }

        public async Task<UserViewModel> GetByName(string name)
        {
            return _mapper.Map<UserViewModel>(await _domainService.GetByName(name));
        }

    }
}
