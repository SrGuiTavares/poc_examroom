using AutoMapper;
using CarDealer.Application.Interface;
using CarDealer.Application.ViewModel;
using CarDealer.Domain.Interface.Service;
using CarDealer.Domain.Model;

namespace CarDealer.Application.Service
{
    public class CarAppService : ICarAppService
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        public CarAppService(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        public async Task<int> Delete(CarViewModel car)
        {
            return await _carService.Delete(_mapper.Map<Car>(car));
        }

        public async Task<IEnumerable<CarViewModel>> GetAll()
        {
            return  _mapper.Map<IEnumerable<CarViewModel>>(await _carService.GetAll());
        }

        public async Task<int> Insert(CarViewModel car)
        {
            return await _carService.Insert(_mapper.Map<Car>(car));
        }

        public async Task<int> Update(CarViewModel car)
        {
            return await _carService.Update(_mapper.Map<Car>(car));
        }
    }
}
