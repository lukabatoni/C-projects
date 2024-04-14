

using UserManagement.Domain.Userss;

namespace UserManagement.Application.User
{
    public interface IUserRepository
    {
        Task<Userss> GetLoginAsync(CancellationToken token, string username, string password);
        Task<Userss> GetUserByIdAsync(CancellationToken cancellationToken, int userId);
        Task CreateUserAsync(CancellationToken cancellationToken, Userss user);
        Task UpdateUserAsync(CancellationToken cancellationToken, Userss user);
        Task DeleteUserAsync(CancellationToken cancellationToken, int userId);
        Task<bool> Exists(CancellationToken cancellationToken, int id);
    }
}
