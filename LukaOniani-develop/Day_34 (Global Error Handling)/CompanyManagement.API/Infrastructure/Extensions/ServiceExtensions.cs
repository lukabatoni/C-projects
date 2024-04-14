using CompanyManagement.Application;

namespace CompanyManagement.API.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            //services.AddTransient<ICompanyService, CompanyService>();
            //services.AddSingleton<ICompanyService, CompanyService>();
            services.AddScoped<ICompanyService, CompanyService>();
        }
    }
}
