using Mapster;
using UserManagement.Application.Users;
using UserManagement.Domain.Userss;




namespace UserManagement.Application.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserResponseModel> AuthenticationAsync(CancellationToken cancellationToken, string username, string password)
        {
            var result = await _repository.GetLoginAsync(cancellationToken, username, password);

            if (result == null)
                throw new Exception("username or password is incorrect");

            return result.Adapt<UserResponseModel>();
        }

        public async Task CreateUserAsync(CancellationToken cancellationToken, string username, string password)
        {
            var login = new UserRequestModel() { Username = username, Password = password};
            var user = login.Adapt<Userss>();

            await _repository.CreateUserAsync(cancellationToken, user);

        }

        public async Task DeleteUserAsync(CancellationToken cancellationToken, int userId)
        {
            if (!await _repository.Exists(cancellationToken, userId))
                throw new Exception();
            await _repository.DeleteUserAsync(cancellationToken, userId);
        }

        public async Task<UserResponseModel> GetUserAsync(CancellationToken cancellationToken, int userId)
        {
            var result = await _repository.GetUserByIdAsync(cancellationToken, userId);
            if (result == null)
                throw new NotImplementedException(); 
            var some = result.Adapt<UserResponseModel>();
            return some;

        }

        public async Task UpdateUserAsync(CancellationToken cancellationToken, int Id, UserUpdateModel userRequest)
        { 
            if(!await _repository.Exists(cancellationToken,Id))
                throw new Exception(); 
            var person = userRequest.Adapt<Userss>();
            person.Id = Id;
            await _repository.UpdateUserAsync(cancellationToken, person);
        }

    }
}
