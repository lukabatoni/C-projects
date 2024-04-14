using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using UserManagement.API.Infrastructure.Auth.JWT;
using UserManagement.Application.TO_DO;
using UserManagement.Application.User;
using UserManagement.Application.Users;

namespace UserManagement.API.Controllers
{
    [Route("v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly IOptions<JWTConfiguration> _options;

        public UserController(IUserService service, IOptions<JWTConfiguration> options)
        {
            _service = service;
            _options = options;
        }

        [HttpPost]
        public async Task Register(string login, string password, CancellationToken cancellation = default)
        {
            await _service.CreateUserAsync(cancellation, login, password);
        }

        [Route("access-token")]
        [HttpPost]
        public async Task<string> LogIn(UserRequestModel user, CancellationToken cancellation = default)
        {
            var result = await _service.AuthenticationAsync(cancellation, user.Username, user.Password);
            return JWTHelper.GenerateSecurityToken(result.Id, _options);
        }

        [Authorize]
        [HttpGet]
        public async Task<UserResponseModel> Get(CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            return await _service.GetUserAsync(cancellationToken, userId);
        }

        [Authorize]
        [HttpPut]
        public async Task Put(CancellationToken cancellation, UserUpdateModel request)
        {
            int Id = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            await _service.UpdateUserAsync(cancellation, Id, request);
        }

        [Authorize]
        [HttpDelete]
        public async Task Delete(CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            await _service.DeleteUserAsync(cancellationToken, userId);
        }
    }
}
