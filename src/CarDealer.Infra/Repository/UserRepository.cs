using CarDealer.Domain.Interface.Repository;
using CarDealer.Domain.Model;
using CarDealer.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Delete(User user)
        {
            _context.Remove(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        public async Task<User> GetByName(string name)
        {
            return await _context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<int> Insert(User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        public async Task<int> Update(User user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }
    }
}
