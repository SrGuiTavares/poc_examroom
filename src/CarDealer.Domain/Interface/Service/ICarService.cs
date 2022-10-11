using CarDealer.Domain.Interface.Service.Base;
using CarDealer.Domain.Model;

namespace CarDealer.Domain.Interface.Service
{
    public interface ICarService : IBaseService<Car>
    {
        Task<IEnumerable<Car>> GetAll();
    }
}
