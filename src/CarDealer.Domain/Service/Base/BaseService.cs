using CarDealer.Domain.Interface.Repository.Base;
using CarDealer.Domain.Interface.Service.Base;

namespace CarDealer.Domain.Service.Base
{
    public class BaseService<T, TRepository> : IBaseService<T> where T : class where TRepository : IBaseRepository<T>
    {
        protected readonly TRepository _repository;
        public BaseService(TRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(T entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<int> Insert(T entity)
        {
            return await _repository.Insert(entity);
        }

        public async Task<int> Update(T entity)
        {
            return await _repository.Update(entity);
        }

    }
}
