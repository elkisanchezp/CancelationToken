using ExampleCancelationToken.Domain.Entities;

namespace ExampleCancelationToken.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetByIdUserAsync(int id);
        Task<IEnumerable<User>> GetAllUsersAsync(CancellationToken cancellationToken = default);

        Task AddAsync(User user, CancellationToken cancellationToken = default);
    }
}
