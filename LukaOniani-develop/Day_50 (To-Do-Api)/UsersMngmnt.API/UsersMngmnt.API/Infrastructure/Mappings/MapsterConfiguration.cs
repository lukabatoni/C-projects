using Mapster;
using System.Security.Claims;
using UserManagement.Application.SubTask;
using UserManagement.Application.TO_DO;
using UserManagement.Application.User;
using UserManagement.Application.Users;
using UserManagement.Domain;
using UserManagement.Domain.SubTask;
using UserManagement.Domain.TO_DOs;
using UserManagement.Domain.Userss;
namespace UserManagement.API.Infrastructure.Mappings
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection services)
        {
            TypeAdapterConfig<UserRequestModel, Userss>
                .NewConfig()
                .Map(dest => dest.PasswordHash, src => src.Password)
                .Map(dest => dest.CreatedAt, src => DateTime.Now)
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .Map(dest => dest.Status, src => Enums.Status.Active)
                .TwoWays();
            TypeAdapterConfig<UserRequestModel, UserResponseModel>
                .NewConfig()
                .TwoWays();
            TypeAdapterConfig<UserUpdateModel, Userss>
                .NewConfig()
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .Map(dest => dest.PasswordHash, src => src.Password)
                .TwoWays();
            TypeAdapterConfig<TO_DORequestModel, ToDos>
                .NewConfig()
                .Map(dest => dest.CreatedAt, src => DateTime.Now)
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .Map(dest => dest.StatusEnum, src => Enums.Status.Active)
                .Map(dest => dest.Subtasks, src => new List<Subtask>())
                .TwoWays();
            TypeAdapterConfig<TO_DORequestModel,TO_DOResponseModel>
                .NewConfig()
                .TwoWays();
            TypeAdapterConfig<TO_DOUpdateModel,ToDos>
                .NewConfig()
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .TwoWays();
            TypeAdapterConfig<SubTaskRequestModel, Subtask>
                .NewConfig()
                .Map(dest => dest.CreatedAt, src => DateTime.Now)
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .Map(dest => dest.Status, src => Enums.Status.Active)
                .TwoWays();
            TypeAdapterConfig<SubTaskRequestModel, SubTaskResponseModel>
                .NewConfig()
                .TwoWays();
            TypeAdapterConfig<SubTaskUpdateModel, Subtask>
                .NewConfig()
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .TwoWays();

        }
    }
}
