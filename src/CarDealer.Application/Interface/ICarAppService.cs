using CarDealer.Application.Interface.Base;
using CarDealer.Application.ViewModel;

namespace CarDealer.Application.Interface
{
    public interface ICarAppService : IBaseAppService<CarViewModel>
    {
        Task<IEnumerable<CarViewModel>> GetAll();
    }
}
