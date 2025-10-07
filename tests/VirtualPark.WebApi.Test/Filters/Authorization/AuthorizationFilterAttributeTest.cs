namespace VirtualPark.WebApi.Test.Filters.Authorization;

[TestClass]
[TestCategory("Filter")]
public sealed class AuthorizationFilterAttributeTest
{
    [TestMethod]
    [TestCategory("Behaviour")]
    public void OnAuthorization_WhenUserHasNotPermission_ShouldReturnForbidden()
    {
        var filter = new AuthorizationFilterAttribute("Attraction-Create");

        var user = new User
        {
            Id = Guid.NewGuid(),
            Email = "test@virtualpark.com",
            Roles = new List<Role>
            {
                new() { 
                    Name = "Visitor", 
                    Permissions = new List<Permission>
                    {
                        new() { Name = "Ranking-Get" }
                    }
                }
            }
        };

        var context = CreateAuthorizationContext();
        context.HttpContext.Items["UserLogged"] = user;

        filter.OnAuthorization(context);

        var result = context.Result as ObjectResult;
        result.Should().NotBeNull();
        result!.StatusCode.Should().Be(StatusCodes.Status403Forbidden);
        result.Value!.ToString().Should().Contain("Missing permission Attraction-Create");
    }

    private static AuthorizationFilterContext CreateAuthorizationContext()
    {
        var httpContext = new DefaultHttpContext();
        var actionContext = new ActionContext
        {
            HttpContext = httpContext,
            RouteData = new Microsoft.AspNetCore.Routing.RouteData(),
            ActionDescriptor = new Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor()
        };

        return new AuthorizationFilterContext(actionContext, new List<IFilterMetadata>());
    }
}
