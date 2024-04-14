using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using UserManagement.API.Infrastructure.Auth.JWT;
using UserManagement.Application.SubTask;


namespace UserManagement.API.Controllers
{
    [Authorize]
    [Route("v1/subtasks")]
    [ApiController]
    public class SubTaskController : ControllerBase
    {
        private readonly ISubTaskService _service;

        public SubTaskController(ISubTaskService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<SubTaskResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            return await _service.GetSubTaskAsync(cancellationToken, id);
        }

        [HttpPut("{id}")]
        public async Task Put(CancellationToken cancellation, int Id, SubTaskUpdateModel request)
        {
            await _service.UpdateSubTaskAsync(cancellation, Id, request);
        }

        [HttpPost]
        public async Task Post(CancellationToken cancellationToken, SubTaskRequestModel request)
        {
            await _service.CreateSubTaskAsync(cancellationToken, request);
        }

        [HttpDelete("{id}")]
        public async Task Delete(CancellationToken cancellationToken, int id)
        {
            await _service.DeleteSubTaskAsync(cancellationToken, id);
        }
    }
}
