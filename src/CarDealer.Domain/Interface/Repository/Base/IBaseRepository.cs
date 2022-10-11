using CarDealer.Domain.Interface.Base;

namespace CarDealer.Domain.Interface.Repository.Base
{
    public interface IBaseRepository<T> : BaseInterface<T> where T : class
    {
    }
}
