using AutoMapper;
using CarDealer.Application.Interface;
using CarDealer.Application.Service.Base;
using CarDealer.Application.ViewModel;
using CarDealer.Domain.Interface.Service;
using CarDealer.Domain.Model;

namespace CarDealer.Application.Service
{
    public class CarAppService : BaseService<Car, CarViewModel, ICarService>, ICarAppService
    {
        public CarAppService(ICarService _domainService, IMapper _mapper) : base(_domainService, _mapper)
        {
        }

        public async Task<IEnumerable<CarViewModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<CarViewModel>>(await _domainService.GetAll());
        }

    }
}
