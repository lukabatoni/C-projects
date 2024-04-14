using Microsoft.EntityFrameworkCore;
using UserManagement.Application.SubTask;
using UserManagement.Domain;
using UserManagement.Domain.SubTask;
using UserManagement.Persistence.Context;

namespace UserManagement.Infrastructure.SubTasks
{
    public class SubTaskRepository : BaseRepository<Subtask>, ISubTaskRepository
    {
        public SubTaskRepository(TO_DOContext context) : base(context)
        {
        }

        public async Task CreateSubTaskAsync(CancellationToken cancellationToken, Subtask task)
        { 
            await AddAsync(cancellationToken, task);
        }

        public async Task DeleteSubTaskAsync(CancellationToken cancellationToken, int Id)
        {
            await RemoveAsync(cancellationToken, Id);
        }

        public async Task<bool> Exists(CancellationToken cancellationToken, int id)
        {
            return await AnyAsync(cancellationToken, x => x.Id == id);
        }

        public async Task<Subtask> GetSubTaskIdAsync(CancellationToken cancellationToken, int Id)
        {
            return await GetAsync(cancellationToken, Id);
        }

        public async Task UpdateSubTasksync(CancellationToken cancellationToken, Subtask task)
        {
            await UpdateAsync(cancellationToken, task);
        }
    }
}
