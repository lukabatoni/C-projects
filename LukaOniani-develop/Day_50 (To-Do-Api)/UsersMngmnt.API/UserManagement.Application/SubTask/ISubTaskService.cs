
namespace UserManagement.Application.SubTask
{
    public interface ISubTaskService
    {
        Task<SubTaskResponseModel> GetSubTaskAsync(CancellationToken cancellationToken, int Id);
        Task CreateSubTaskAsync(CancellationToken cancellationToken, SubTaskRequestModel userRequest);
        Task UpdateSubTaskAsync(CancellationToken cancellationToken, int Id, SubTaskUpdateModel userRequest);
        Task DeleteSubTaskAsync(CancellationToken cancellationToken, int Id);
    }
}
