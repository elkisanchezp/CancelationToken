using ExampleCancelationToken.Domain.Entities;
using ExampleCancelationToken.Domain.Repositories;
using ExampleCancelationToken.Infraextructura.Persistence.MysqlContext;
using Microsoft.EntityFrameworkCore;

namespace ExampleCancelationToken.Infraextructura.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task<User?> GetByIdUserAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(CancellationToken cancellationToken)
        {
            // Simulation
            await Task.Delay(10000, cancellationToken);
            return await _context.Users.ToListAsync(cancellationToken);
        }

        public async Task AddAsync(User user, CancellationToken cancellationToken)
        {
            await Task.Delay(10000, cancellationToken);
            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
