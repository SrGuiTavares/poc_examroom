using CarDealer.Domain.Interface.Repository;
using CarDealer.Domain.Model;
using CarDealer.Infra.Context;

namespace CarDealer.Infra.Repository
{
    public class CarRepository : ICarRepository
    {
        protected readonly AppDbContext _context;

        public CarRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Delete(Car car)
        {
            _context.Remove(car);
            await _context.SaveChangesAsync();

            return car.Id;
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            return _context.Cars.ToList();
        }

        public async Task<int> Insert(Car car)
        {
            await _context.AddAsync(car);
            await _context.SaveChangesAsync();

            return car.Id;
        }

        public async Task<int> Update(Car car)
        {
            _context.Update(car);
            await _context.SaveChangesAsync();

            return car.Id;
        }
    }
}
