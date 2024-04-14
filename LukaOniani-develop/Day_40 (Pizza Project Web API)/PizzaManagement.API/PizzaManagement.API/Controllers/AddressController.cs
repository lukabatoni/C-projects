using Mapster;
using Microsoft.AspNetCore.Mvc;
using PizzaManagement.API.Model.Examples.Address;
using PizzaManagement.API.Model.Requests;
using PizzaManagement.Application.Entities.AddressFolder;
using Swashbuckle.AspNetCore.Filters;

namespace AddressManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _AddressService;

        public AddressController(IAddressService AddressService)
        {
            _AddressService = AddressService;
        }

        #region EndPoints

        /// <summary>
        /// Retrieves all addresses.
        /// </summary>
        /// <returns>A list of all addresses.</returns>
        /// <response code="200">All the addresses are returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(AddressListExample))]
        [HttpGet]
        public async Task<List<AddressResponseModel>> GetAll()
        {
            return await _AddressService.GetAll();
        }

        /// <summary>
        /// Retrieves an address by ID.
        /// </summary>
        /// <param name="id">The ID of the address.</param>
        /// <returns>The address corresponding to the provided ID.</returns>
        /// <response code="200">The address corresponding to the provided ID is returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(AddressResponseExample))]
        [HttpGet("{id}")]
        public async Task<AddressResponseModel> Get(int id)
        {
            return await _AddressService.Get(id);
        }

        /// <summary>
        /// Retrieves addresses by multiple IDs.
        /// </summary>
        /// <param name="ids">Array of address IDs.</param>
        /// <returns>Addresses corresponding to the provided IDs.</returns>
        /// <response code="200">Addresses corresponding to the provided IDs are returned.</response>
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(AddressListExample))]
        [HttpGet("GetMany")]
        public async Task<List<AddressResponseModel>> GetMany([FromQuery] int[] ids)
        {
            return await _AddressService.GetMany(ids);
        }

        /// <summary>
        /// Creates an address.
        /// </summary>        
        /// <remarks>
        /// Note that ID is not necessary.
        /// </remarks>
        /// <param name="request">The data required to create the address.</param>
        /// <response code="200">The address is successfully created.</response>
        [SwaggerRequestExample(typeof(AddressCreateModel), typeof(AddressCreateExample))]
        [HttpPost]
        public async Task Post(AddressCreateModel request)
        {
            var entity = request.Adapt<AddressRequestModel>();
            entity.Id = await _AddressService.Length() + 1;
            await _AddressService.Create(entity);
        }

        /// <summary>
        /// Deletes an address by ID.
        /// </summary>
        /// <param name="id">The ID of the address to delete.</param>
        /// <response code="200">The address is successfully deleted.</response>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _AddressService.Delete(id);
        }

        /// <summary>
        /// Updates an address.
        /// </summary>        
        /// <param name="address">The updated address data.</param>
        /// <response code="200">The address is successfully updated.</response>
        [SwaggerRequestExample(typeof(AddressRequestModel), typeof(AddressResponseExample))]
        [HttpPut]
        public async Task Put(AddressRequestModel address)
        {
            await _AddressService.Update(address);
        }
        #endregion
    }
}
