using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using UserManagement.API.Infrastructure.Auth.JWT;
using UserManagement.Application.TO_DO;
using UserManagement.Domain.TO_DOs;


namespace UserManagement.API.Controllers
{
    [Authorize]
    [Route("v1/todos")]
    [ApiController]
    public class TO_DOController : ControllerBase
    {
        private readonly ITO_DOService _service;

        public TO_DOController(ITO_DOService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<TO_DOResponseModel>> GetAll(CancellationToken cancellationToken) {
            int ownerid = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            return await _service.GetAllToDoAsync(cancellationToken, ownerid);
        }


        [HttpGet("{id}")]
        public async Task<TO_DOResponseModel> Get(CancellationToken cancellationToken, int id) {
            return await _service.GetTODOAsync(cancellationToken, id);
        }

        [HttpPut("{id}")]
        public async Task Put(CancellationToken cancellation, int Id, TO_DOUpdateModel request) {
            request.OwnerId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            await _service.UpdateTODOAsync(cancellation, Id, request);
        }

        [HttpPost]
        public async Task Post(CancellationToken cancellationToken, TO_DORequestModel request) {
            request.OwnerId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            await _service.CreateTODOAsync(cancellationToken, request);
        }

        [HttpDelete("{id}")]
        public async Task Delete(CancellationToken cancellationToken, int id) { 
            await _service.DeleteTODOAsync(cancellationToken, id);
        }

    }   
}
