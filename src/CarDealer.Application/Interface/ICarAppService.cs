using CarDealer.Application.ViewModel;
using CarDealer.Domain.Model;

namespace CarDealer.Application.Interface
{
    public interface ICarAppService
    {
        Task<int> Insert(CarViewModel car);
        Task<int> Update(CarViewModel car);
        Task<int> Delete(CarViewModel car);
        Task<IEnumerable<CarViewModel>> GetAll();
    }
}
