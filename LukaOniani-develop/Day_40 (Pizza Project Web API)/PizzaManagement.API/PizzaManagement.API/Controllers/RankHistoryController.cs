using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaManagement.API.Model;
using PizzaManagement.API.Model.Examples.Address;
using PizzaManagement.API.Model.Examples.Pizza;
using PizzaManagement.API.Model.Examples.RankHistory;
using PizzaManagement.API.Model.Requests;
using PizzaManagement.Application.Entities.RankHistoryFolder;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankHistoryController : ControllerBase
    {
        private readonly IRankHistoryService _RankHistoryService;

        public RankHistoryController(IRankHistoryService RankHistoryService)
        {
            _RankHistoryService = RankHistoryService;
        }

        #region EndPoints

        /// <summary>
        /// Retrieves all ranks.
        /// </summary>
        /// <returns>A list of all ranks.</returns>
        /// <response code="200">All the ranks are returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RankHistoryListExample))]
        [HttpGet]
        public async Task<List<RankHistoryResponseModel>> GetAll()
        {
            return await _RankHistoryService.GetAll();
        }

        /// <summary>
        /// Retrieves a rank by user and pizza ID.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="pizzaId">The ID of the pizza.</param>
        /// <returns>The rank corresponding to the provided user and pizza IDs.</returns>
        /// <response code="200">The rank corresponding to the provided user and pizza IDs is returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RankHistoryExample))]
        [HttpGet("{userId}/{pizzaId}")]
        public async Task<RankHistoryResponseModel> Get(int userId, int pizzaId)
        {
            return await _RankHistoryService.Get(userId, pizzaId);
        }

        /// <summary>
        /// Retrieves ranks by multiple IDs.
        /// </summary>
        /// <param name="ids">Array of user and pizza ID tuples.</param>
        /// <returns>Ranks corresponding to the provided IDs.</returns>
        /// <response code="200">Ranks corresponding to the provided IDs are returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RankHistoryListExample))]
        [HttpGet("GetMany")]
        public async Task<List<RankHistoryResponseModel>> GetMany([FromQuery] (int, int)[] ids)
        {
            var parameters = ids.Select(tuple => (tuple.Item1, tuple.Item2)).ToArray();
            return await _RankHistoryService.GetMany(parameters);
        }

        /// <summary>
        /// Creates a rank.
        /// </summary>
        /// <remarks>
        /// Note that ID is not necessary.
        /// </remarks>
        /// <param name="request">The data required to create the rank.</param>
        /// <response code="200">The rank is successfully created.</response>
        [SwaggerRequestExample(typeof(RankHistoryCreateModel), typeof(RankHistoryExample))]
        [HttpPost]
        public async Task Post(RankHistoryCreateModel request)
        {
            var entity = request.Adapt<RankHistoryRequestModel>();
            await _RankHistoryService.Create(entity);
        }

        #endregion
    }
}
