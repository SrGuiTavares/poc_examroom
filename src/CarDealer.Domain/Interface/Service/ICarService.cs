using CarDealer.Domain.Model;

namespace CarDealer.Domain.Interface.Service
{
    public  interface ICarService
    {
        Task<int> Insert(Car car);
        Task<int> Update(Car car);
        Task<int> Delete(Car car);
        Task<IEnumerable<Car>> GetAll();
    }
}
