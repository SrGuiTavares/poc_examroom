using CarDealer.Domain.Interface.Repository;
using CarDealer.Domain.Model;
using CarDealer.Infra.Context;
using CarDealer.Infra.Repository.Base;

namespace CarDealer.Infra.Repository
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            try
            {
                return _context.Cars.ToList();
            }
            catch (Exception ex)
            {

                return Enumerable.Empty<Car>();
            }
        }

    }
}
