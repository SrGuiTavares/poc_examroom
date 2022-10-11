namespace CarDealer.Application.Interface.Base
{
    public interface IBaseAppService<T> where T : class
    {
        Task<int> Insert(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
