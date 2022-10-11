using CarDealer.Domain.Interface.Repository.Base;
using CarDealer.Domain.Model.Base;
using CarDealer.Infra.Context;

namespace CarDealer.Infra.Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Delete(T entity)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    _context.Remove(entity);
                    await _context.SaveChangesAsync();

                    transaction.Commit();

                    return entity.Id;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

        public async Task<int> Insert(T entity)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    _context.Add(entity);
                    await _context.SaveChangesAsync();

                    transaction.Commit();

                    return entity.Id;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

        public async Task<int> Update(T entity)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    _context.Update(entity);
                    await _context.SaveChangesAsync();

                    transaction.Commit();

                    return entity.Id;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

    }
}
