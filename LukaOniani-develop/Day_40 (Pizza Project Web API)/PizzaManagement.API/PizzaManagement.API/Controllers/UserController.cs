using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaManagement.API.Model.DTO;
using PizzaManagement.API.Model.Examples.Pizza;
using PizzaManagement.API.Model.Examples.User;
using PizzaManagement.API.Model.Requests;
using PizzaManagement.Application.Entities.PizzaFolder;
using PizzaManagement.Application.Entities.UserFolder;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _UserService;

        public UserController(IUserService UserService)
        {
            _UserService = UserService;
        }

        #region EndPoints

        /// <summary>
        /// Retrieves all users.
        /// </summary>
        /// <returns>A list of all users.</returns>
        /// <response code="200">All the users are returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(UserDTOListExample))]
        [HttpGet]
        public async Task<List<UserResponseDTO>> GetAll()
        {
            var result = await _UserService.GetAll();
            return result.Adapt<List<UserResponseDTO>>();
        }

        /// <summary>
        /// Retrieves a user by ID.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <returns>The user corresponding to the provided ID.</returns>
        /// <response code="200">The user corresponding to the provided ID is returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(UserDTOExample))]
        [HttpGet("{id}")]
        public async Task<UserResponseDTO> Get(int id)
        {
            var result = await _UserService.Get(id);
            return result.Adapt<UserResponseDTO>();
        }

        /// <summary>
        /// Retrieves users by multiple IDs.
        /// </summary>
        /// <param name="ids">Array of user IDs.</param>
        /// <returns>Users corresponding to the provided IDs.</returns>
        /// <response code="200">Users corresponding to the provided IDs are returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(UserDTOListExample))]
        [HttpGet("GetMany")]
        public async Task<List<UserResponseDTO>> GetMany([FromQuery] int[] ids)
        {
            var result = await _UserService.GetMany(ids);
            return result.Adapt<List<UserResponseDTO>>();
        }

        /// <summary>
        /// Creates a user.
        /// </summary>        
        /// <remarks>
        /// Note that ID is not necessary.
        /// </remarks>
        /// <param name="request">The data required to create the user.</param>
        /// <response code="200">The user is successfully created.</response>
        [SwaggerRequestExample(typeof(UserCreateModel), typeof(UserCreateExample))]
        [HttpPost]
        public async Task Post(UserCreateModel request)
        {
            var entity = request.Adapt<UserRequestModel>();
            entity.Id = await _UserService.Length() + 1;
            await _UserService.Create(entity);
        }

        /// <summary>
        /// Deletes a user by ID.
        /// </summary>
        /// <param name="id">The ID of the user to delete.</param>
        /// <response code="200">The user is successfully deleted.</response>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _UserService.Delete(id);
        }

        /// <summary>
        /// Updates a user.
        /// </summary>        
        /// <param name="user">The updated user data.</param>
        /// <response code="200">The user is successfully updated.</response>
        [SwaggerRequestExample(typeof(UserRequestModel), typeof(UserRequestExample))]
        [HttpPut]
        public async Task Put(UserRequestModel user)
        {
            await _UserService.Update(user);
        }
        #endregion
    }
}
