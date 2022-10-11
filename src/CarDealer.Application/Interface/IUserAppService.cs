using CarDealer.Application.Interface.Base;
using CarDealer.Application.ViewModel;

namespace CarDealer.Application.Interface
{
    public interface IUserAppService : IBaseAppService<UserViewModel>
    {
        Task<UserViewModel> GetByName(string name);
    }
}
