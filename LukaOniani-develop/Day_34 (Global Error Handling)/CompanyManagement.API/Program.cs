using CompanyManagement.API.Infrastructure.Extensions;
using CompanyManagement.API.Infrastructure.Middlewares;
using Microsoft.AspNetCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServices();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlerMiddlware>();


//if (app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/error/error-local-development");
//}
//else
//{
//    app.UseExceptionHandler("/error/error");
//}


app.MapControllers();

app.Run();
