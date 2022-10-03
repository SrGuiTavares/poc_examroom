using CarDealer.Domain.Model;

namespace CarDealer.Domain.Interface.Repository
{
    public interface ICarRepository
    {
        Task<int> Insert(Car car);
        Task<int> Update(Car car);
        Task<int> Delete(Car car);
        Task<IEnumerable<Car>> GetAll();
    }
}
