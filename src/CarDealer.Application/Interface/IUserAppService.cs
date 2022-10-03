using CarDealer.Application.ViewModel;
using CarDealer.Domain.Model;

namespace CarDealer.Application.Interface
{
    public interface IUserAppService
    {
        Task<int> Insert(UserViewModel user);
        Task<int> Update(UserViewModel user);
        Task<int> Delete(UserViewModel user);
        Task<UserViewModel> GetByName(string name);
    }
}
