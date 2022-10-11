using CarDealer.Domain.Interface.Repository;
using CarDealer.Domain.Interface.Service;
using CarDealer.Domain.Model;
using CarDealer.Domain.Service.Base;

namespace CarDealer.Domain.Service
{
    public class CarService : BaseService<Car, ICarRepository>, ICarService
    {
        public CarService(ICarRepository repository) : base(repository)
        {
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            return await _repository.GetAll();
        }

    }
}
