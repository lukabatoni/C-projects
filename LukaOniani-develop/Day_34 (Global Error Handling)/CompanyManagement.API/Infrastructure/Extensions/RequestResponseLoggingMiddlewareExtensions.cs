using CompanyManagement.API.Infrastructure.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace CompanyManagement.API.Infrastructure.Extensions
{
    public static class RequestResponseLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestResponseLogging(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<RequestResponseLoggin>();

            return builder;
        }
    }
}
