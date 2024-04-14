using UserManagement.Domain.TO_DOs;


namespace UserManagement.Application.TO_DO
{
    public interface ITO_DORepository
    {
        Task<ToDos> GetTODOByIdAsync(CancellationToken cancellationToken, int Id);
        Task CreateTODOAsync(CancellationToken cancellationToken, ToDos TODO);
        Task UpdateTODOAsync(CancellationToken cancellationToken, ToDos TODO);
        Task DeleteTODOAsync(CancellationToken cancellationToken, int Id);
        Task<bool> Exists(CancellationToken cancellationToken, int id);
        Task<List<ToDos>> GetAllToDoAsync(CancellationToken cancellationToken,int ownerid);
        
    }
}