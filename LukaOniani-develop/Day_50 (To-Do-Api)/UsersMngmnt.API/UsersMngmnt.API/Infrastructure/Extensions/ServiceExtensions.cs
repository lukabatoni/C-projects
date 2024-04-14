using UserManagement.Application.SubTask;
using UserManagement.Application.TO_DO;
using UserManagement.Application.User;
using UserManagement.Infrastructure.SubTasks;
using UserManagement.Infrastructure.TO_DOs;
using UserManagement.Infrastructure.User;

namespace UserManagement.API.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services) {

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ISubTaskService, SubTaskService>();
            services.AddScoped<ISubTaskRepository, SubTaskRepository>();

            services.AddScoped<ITO_DOService, TO_DOService>();
            services.AddScoped<ITO_DORepository, TO_DORepository>();
        }
    }
}
