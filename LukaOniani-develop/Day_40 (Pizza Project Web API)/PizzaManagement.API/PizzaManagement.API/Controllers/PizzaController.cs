using Mapster;
using Microsoft.AspNetCore.Mvc;
using PizzaManagement.API.Model.Examples.Pizza;
using PizzaManagement.API.Model.Requests;
using PizzaManagement.Application.Entities.PizzaFolder;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _PizzaService;

        public PizzaController(IPizzaService PizzaService)
        {
            _PizzaService = PizzaService;
        }

        #region EndPoints

        /// <summary>
        /// Retrieves all pizzas.
        /// </summary>
        /// <returns>A list of all pizzas.</returns>
        /// <response code="200">All the pizzas are returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(PizzaListResponseExample))]
        [HttpGet]
        public async Task<List<PizzaResponseModel>> GetAll()
        {
            return await _PizzaService.GetAll();
        }

        /// <summary>
        /// Retrieves a pizza by ID.
        /// </summary>
        /// <param name="id">The ID of the pizza.</param>
        /// <returns>The pizza corresponding to the provided ID.</returns>
        /// <response code="200">The pizza corresponding to the provided ID is returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(PizzaResponseExample))]
        [HttpGet("{id}")]
        public async Task<PizzaResponseModel> Get(int id)
        {
            return await _PizzaService.Get(id);
        }

        /// <summary>
        /// Retrieves pizzas by multiple IDs.
        /// </summary>
        /// <param name="ids">Array of pizza IDs.</param>
        /// <returns>Pizzas corresponding to the provided IDs.</returns>
        /// <response code="200">Pizzas corresponding to the provided IDs are returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(PizzaListResponseExample))]
        [HttpGet("GetMany")]
        public async Task<List<PizzaResponseModel>> GetMany([FromQuery] int[] ids)
        {
            return await _PizzaService.GetMany(ids);
        }

        /// <summary>
        /// Creates a pizza.
        /// </summary>        
        /// <remarks>
        /// Note that ID is not necessary.
        /// </remarks>
        /// <param name="request">The data required to create the pizza.</param>
        /// <response code="200">The pizza is successfully created.</response>
        [SwaggerRequestExample(typeof(PizzaCreateModel), typeof(PizzaCreateExample))]
        [HttpPost]
        public async Task Post(PizzaCreateModel request)
        {
            var entity = request.Adapt<PizzaRequestModel>();
            entity.Id = await _PizzaService.Length() + 1;
            await _PizzaService.Create(entity);
        }

        /// <summary>
        /// Deletes a pizza by ID.
        /// </summary>
        /// <param name="id">The ID of the pizza to delete.</param>
        /// <response code="200">The pizza is successfully deleted.</response>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _PizzaService.Delete(id);
        }

        /// <summary>
        /// Updates a pizza.
        /// </summary>        
        /// <param name="pizza">The updated pizza data.</param>
        /// <response code="200">The pizza is successfully updated.</response>
        [SwaggerRequestExample(typeof(PizzaRequestModel), typeof(PizzaResponseExample))]
        [HttpPut]
        public async Task Put(PizzaRequestModel pizza)
        {
            await _PizzaService.Update(pizza);
        }
        #endregion
    }
}
