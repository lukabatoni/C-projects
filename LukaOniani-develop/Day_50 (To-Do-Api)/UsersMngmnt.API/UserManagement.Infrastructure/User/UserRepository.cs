using Microsoft.EntityFrameworkCore;
using UserManagement.Application.User;
using UserManagement.Domain;
using UserManagement.Domain.Userss;
using UserManagement.Persistence.Context;

namespace UserManagement.Infrastructure.User
{
    public class UserRepository : BaseRepository<Userss>, IUserRepository
    {
        public UserRepository(TO_DOContext context) : base(context)
        {

        }
        public async Task<Userss?> GetLoginAsync(CancellationToken token, string username, string password)
        {
            var result = _dbSet.SingleOrDefault(x => x.Username == username && x.PasswordHash == password);
            return result;
        }

        public async Task CreateUserAsync(CancellationToken cancellationToken, Userss user)
        {
            await base.AddAsync(cancellationToken, user);
        }

        public async Task DeleteUserAsync(CancellationToken cancellationToken, int userId)
        {
            await base.RemoveAsync(cancellationToken, userId);
        }

        public async Task<bool> Exists(CancellationToken cancellationToken, int id)
        {
            return await base.AnyAsync(cancellationToken, x => x.Id == id);
        }

        public async Task<Userss?> GetUserByIdAsync(CancellationToken cancellationToken, int userId)
        {
            return await base.GetAsync(cancellationToken, userId);
        }

        public async Task UpdateUserAsync(CancellationToken cancellationToken, Userss user)
        {
            await base.UpdateAsync(cancellationToken, user);
        }
    }
}
