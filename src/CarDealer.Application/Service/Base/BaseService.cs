using AutoMapper;
using CarDealer.Application.Interface.Base;
using CarDealer.Domain.Interface.Service.Base;

namespace CarDealer.Application.Service.Base
{
    public class BaseService<TModel, TViewModel, TService> : IBaseAppService<TViewModel>
                                where TModel : class
                                where TViewModel : class
                                where TService : IBaseService<TModel>
    {

        protected readonly TService _domainService;
        protected readonly IMapper _mapper;

        public BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public BaseService(TService iBaseService, IMapper mapper)
        {
            _domainService = iBaseService;
            _mapper = mapper;
        }

        public async Task<int> Delete(TViewModel entity)
        {
            return await _domainService.Delete(_mapper.Map<TModel>(entity));
        }

        public async Task<int> Insert(TViewModel entity)
        {
            return await _domainService.Insert(_mapper.Map<TModel>(entity));
        }

        public async Task<int> Update(TViewModel entity)
        {
            return await _domainService.Update(_mapper.Map<TModel>(entity));
        }

    }
}
