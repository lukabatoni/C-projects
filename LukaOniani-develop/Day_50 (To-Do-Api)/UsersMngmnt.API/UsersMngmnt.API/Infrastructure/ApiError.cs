using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using System.Net;
using UserManagement.Application.Exceptions;
using UserManagement.API.Infrastructure.Localization;

namespace UserManagement.API.Infrastructure
{
    public class ApiError : ProblemDetails
    {
        public const string UnhandlerErrorCode = "UnhandledError";
        private HttpContext _httpContext;
        private Exception _exception;

        public LogLevel LogLevel { get; set; }
        public string Code { get; set; }

        public string? TraceId
        {
            get
            {
                if (Extensions.TryGetValue("TraceId", out var traceId))
                {
                    return (string?)traceId;
                }

                return null;
            }

            set => Extensions["TraceId"] = value;
        }

        public ApiError(HttpContext httpContext, Exception exception)
        {
            _httpContext = httpContext;
            _exception = exception;

            TraceId = httpContext.TraceIdentifier;

            //default
            Code = UnhandlerErrorCode;
            Status = (int)HttpStatusCode.InternalServerError;
            Title = ErrorMessages.Error;
            LogLevel = LogLevel.Error;
            Instance = httpContext.Request.Path;

            HandleException((dynamic)exception);
        }

      
        private void HandleException(UserNotFoundException exception)
        {
            Code = exception.Code;
            Status = (int)HttpStatusCode.BadRequest;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4";
            Title = ErrorMessages.UserNotFound;
            LogLevel = LogLevel.Information;
        }

        private void HandleException(UserAlreadyExistsException exception)
        {
            Code = exception.Code;
            Status = (int)HttpStatusCode.Conflict;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.9";
            Title = ErrorMessages.UserConflict;
            LogLevel = LogLevel.Information;
        }
        private void HandleException(Exception exception)
        {
            Code = exception.Message;
            Status = (int)HttpStatusCode.BadRequest;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1";
            Title = ErrorMessages.Error;
            LogLevel = LogLevel.Information;
        }
    }
}