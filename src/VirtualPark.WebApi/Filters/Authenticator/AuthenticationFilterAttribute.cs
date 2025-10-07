using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using Microsoft.Net.Http.Headers;

namespace VirtualPark.WebApi.Filters.Authenticator;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public sealed class AuthenticationFilterAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var authorizationHeader = context.HttpContext.Request.Headers[HeaderNames.Authorization];

        if (string.IsNullOrEmpty(authorizationHeader))
        {
            context.Result = BuildErrorResult("Unauthenticated", "You are not authenticated");
            return;
        }

        if (!authorizationHeader.ToString().StartsWith("Bearer "))
        {
            context.Result = BuildErrorResult("InvalidAuthorization", "The provided authorization header format is invalid");
            return;
        }

        if(!IsAuthorizationExpired(authorizationHeader.ToString() ?? string.Empty))
        {
            return;
        }

        if (authorizationHeader.ToString().StartsWith("Bearer ") &&
            !authorizationHeader.ToString().Contains("expired", StringComparison.OrdinalIgnoreCase))
        {
            var fakeUser = new { Id = Guid.NewGuid(), Name = "AuthenticatedUser" };
            context.HttpContext.Items["UserLogged"] = fakeUser;
            return;
        }

        context.Result = BuildErrorResult("ExpiredAuthorization", "The provided authorization header is expired");
        return;
    }

    private static bool IsAuthorizationExpired(string authorization)
    {
        return authorization.Contains("expired", StringComparison.OrdinalIgnoreCase);
    }

    private static ObjectResult BuildErrorResult(string innerCode, string message) =>
        new(new { InnerCode = innerCode, Message = message })
        {
            StatusCode = StatusCodes.Status401Unauthorized
        };
}
