using Mapster;
using UserManagement.Domain;
using UserManagement.Domain.TO_DOs;

namespace UserManagement.Application.TO_DO
{
    public class TO_DOService : ITO_DOService
    {
        private readonly ITO_DORepository _repository;

        public TO_DOService(ITO_DORepository repository)
        {
            _repository = repository;
        }

        public async Task CreateTODOAsync(CancellationToken cancellationToken, TO_DORequestModel TODO)
        {
            var todo = TODO.Adapt<ToDos>();
            await _repository.CreateTODOAsync(cancellationToken, todo);
        }

        public async Task DeleteTODOAsync(CancellationToken cancellationToken, int Id)
        {
            if (!await _repository.Exists(cancellationToken, Id))
                throw new Exception();
            await _repository.DeleteTODOAsync(cancellationToken, Id);
        }

        public async Task<List<TO_DOResponseModel>> GetAllToDoAsync(CancellationToken cancellationToken, int ownerid)
        {
            var result = await _repository.GetAllToDoAsync(cancellationToken,ownerid);
            if(result == null)
                throw new Exception();
            else
                return result.Adapt<List<TO_DOResponseModel>>();
        }

        public async Task<TO_DOResponseModel> GetTODOAsync(CancellationToken cancellationToken, int Id)
        {
            var result = await _repository.GetTODOByIdAsync(cancellationToken, Id);
            if (result == null || result.StatusEnum == Enums.Status.Deleted)
                throw new Exception(); 
            else
                return result.Adapt<TO_DOResponseModel>();
        }

        public async Task UpdateTODOAsync(CancellationToken cancellationToken, int Id, TO_DOUpdateModel TODO)
        {
            if(!await _repository.Exists(cancellationToken,Id))
                throw new Exception(); 
            var todo = TODO.Adapt<ToDos>();
            todo.Id = Id;
            await _repository.UpdateTODOAsync(cancellationToken, todo);
        }
    }
}
