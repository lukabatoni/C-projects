using UserManagement.Application.Users;

namespace UserManagement.Application.User
{
    public interface IUserService
    {
        Task<UserResponseModel> AuthenticationAsync(CancellationToken cancellation, string username, string password);
        Task<UserResponseModel> GetUserAsync(CancellationToken cancellationToken, int userId);
        Task CreateUserAsync(CancellationToken cancellationToken, string login, string password);
        Task UpdateUserAsync(CancellationToken cancellationToken, int Id, UserUpdateModel userRequest);
        Task DeleteUserAsync(CancellationToken cancellationToken, int userId);
    }
}
