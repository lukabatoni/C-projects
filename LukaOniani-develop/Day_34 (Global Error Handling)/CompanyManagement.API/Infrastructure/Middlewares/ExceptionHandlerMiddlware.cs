using Newtonsoft.Json;

namespace CompanyManagement.API.Infrastructure.Middlewares
{
    public class ExceptionHandlerMiddlware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddlware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);

            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var error = new ApiError(context, ex);
            var result = JsonConvert.SerializeObject(error);

            context.Response.Clear();
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = error.Status.Value;


            await File.AppendAllTextAsync(@"C:\Users\lukaa\Desktop\New folder (2)\Day_34 (Global Error Handling)\Exceptions_Log.txt", "\n" + result.ToString());

            await context.Response.WriteAsync(result);
        }
    }
}