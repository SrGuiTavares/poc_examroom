using CarDealer.Domain.Interface.Repository;
using CarDealer.Domain.Interface.Service;
using CarDealer.Domain.Model;

namespace CarDealer.Domain.Service
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<int> Delete(Car car)
        {
            return await _carRepository.Delete(car);
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            return await _carRepository.GetAll();
        }

        public async Task<int> Insert(Car car)
        {
            return await _carRepository.Insert(car);
        }

        public async Task<int> Update(Car car)
        {
            return await _carRepository.Update(car);
        }
    }
}
