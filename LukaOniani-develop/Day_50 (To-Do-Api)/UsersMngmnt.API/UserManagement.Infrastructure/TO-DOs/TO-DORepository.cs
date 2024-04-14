using Microsoft.EntityFrameworkCore;
using UserManagement.Application.TO_DO;
using UserManagement.Domain;
using UserManagement.Domain.TO_DOs;
using UserManagement.Persistence.Context;


namespace UserManagement.Infrastructure.TO_DOs
{
    public class TO_DORepository : BaseRepository<ToDos>, ITO_DORepository
    {
        public TO_DORepository(TO_DOContext context) : base(context)
        {

        }

        public async Task CreateTODOAsync(CancellationToken cancellationToken, ToDos TODO)
        {
            await base.AddAsync(cancellationToken, TODO);
        }

        public async Task DeleteTODOAsync(CancellationToken cancellationToken, int Id)
        {
            await base.RemoveAsync(cancellationToken, Id);
        }

        public async Task<bool> Exists(CancellationToken cancellationToken, int id)
        {
            return await base.AnyAsync(cancellationToken, x => x.Id == id);
        }

        public async Task<List<ToDos>> GetAllToDoAsync(CancellationToken cancellationToken,int ownerid)
        {
            var result = await base.GetAllAsync(cancellationToken);
            return result.Where(x => x.OwnerId == ownerid && x.StatusEnum == Enums.Status.Active).ToList();
        }

   

        public Task<ToDos> GetTODOByIdAsync(CancellationToken cancellationToken, int Id)
        {
            return base.GetAsync(cancellationToken, Id);
        }

        public async Task UpdateTODOAsync(CancellationToken cancellationToken, ToDos TODO)
        {
            await base.UpdateAsync(cancellationToken, TODO);
        }
    }
}
