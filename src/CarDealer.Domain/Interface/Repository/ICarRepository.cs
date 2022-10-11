using CarDealer.Domain.Interface.Repository.Base;
using CarDealer.Domain.Model;

namespace CarDealer.Domain.Interface.Repository
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        Task<IEnumerable<Car>> GetAll();
    }
}
