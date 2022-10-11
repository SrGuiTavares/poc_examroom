using CarDealer.Domain.Interface.Repository;
using CarDealer.Domain.Model;
using CarDealer.Infra.Context;
using CarDealer.Infra.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Infra.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User> GetByName(string name)
        {
            try
            {
                return await _context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Name == name);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
