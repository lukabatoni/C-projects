using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaManagement.API.Model.DTO;
using PizzaManagement.API.Model.Examples.Order;
using PizzaManagement.API.Model.Examples.Pizza;
using PizzaManagement.API.Model.Requests;
using PizzaManagement.Application.Entities.OrderFolder;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _OrderService;

        public OrderController(IOrderService OrderService)
        {
            _OrderService = OrderService;
        }

        #region EndPoints

        /// <summary>
        /// Retrieves all orders.
        /// </summary>
        /// <returns>A list of all orders.</returns>
        /// <response code="200">All the orders are returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(OrderDTOListExample))]
        [HttpGet]
        public async Task<List<OrderResponseDTO>> GetAll()
        {
            var result = await _OrderService.GetAll();
            return result.Adapt<List<OrderResponseDTO>>();
        }

        /// <summary>
        /// Retrieves an order by ID.
        /// </summary>
        /// <param name="id">The ID of the order.</param>
        /// <returns>The order corresponding to the provided ID.</returns>
        /// <response code="200">The order corresponding to the provided ID is returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(OrderDTOExample))]
        [HttpGet("{id}")]
        public async Task<OrderResponseDTO> Get(int id)
        {
            var result = await _OrderService.Get(id);
            return result.Adapt<OrderResponseDTO>();
        }

        /// <summary>
        /// Retrieves orders by multiple IDs.
        /// </summary>
        /// <param name="ids">Array of order IDs.</param>
        /// <returns>Orders corresponding to the provided IDs.</returns>
        /// <response code="200">Orders corresponding to the provided IDs are returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(OrderDTOListExample))]
        [HttpGet("GetMany")]
        public async Task<List<OrderResponseDTO>> GetMany([FromQuery] int[] ids)
        {
            var result = await _OrderService.GetMany(ids);
            return result.Adapt<List<OrderResponseDTO>>();
        }

        /// <summary>
        /// Creates an order.
        /// </summary>        
        /// <remarks>
        /// Note that ID is not necessary.
        /// </remarks>
        /// <param name="request">The data required to create the order.</param>
        /// <response code="200">The order is successfully created.</response>
        [SwaggerRequestExample(typeof(OrderCreateModel), typeof(OrderCreateExample))]
        [HttpPost]
        public async Task Post(OrderCreateModel request)
        {
            var entity = request.Adapt<OrderRequestModel>();
            entity.Id = await _OrderService.Length() + 1;
            await _OrderService.Create(entity);
        }


        #endregion
    }
}
