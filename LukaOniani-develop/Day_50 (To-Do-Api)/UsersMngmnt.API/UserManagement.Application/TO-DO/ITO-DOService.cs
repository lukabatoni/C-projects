namespace UserManagement.Application.TO_DO
{
    public interface ITO_DOService
    {
        Task<TO_DOResponseModel> GetTODOAsync(CancellationToken cancellationToken, int Id);
        Task CreateTODOAsync(CancellationToken cancellationToken, TO_DORequestModel TODO);
        Task UpdateTODOAsync(CancellationToken cancellationToken, int Id, TO_DOUpdateModel TODO);
        Task DeleteTODOAsync(CancellationToken cancellationToken, int Id);
        Task<List<TO_DOResponseModel>> GetAllToDoAsync(CancellationToken cancellationToken, int ownerid);

    }
}
