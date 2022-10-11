using CarDealer.Domain.Interface.Base;

namespace CarDealer.Domain.Interface.Service.Base
{
    public interface IBaseService<T> : BaseInterface<T> where T : class
    {
    }
}
