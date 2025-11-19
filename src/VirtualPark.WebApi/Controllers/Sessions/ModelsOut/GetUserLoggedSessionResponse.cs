using VirtualPark.BusinessLogic.Users.Entity;

namespace VirtualPark.WebApi.Controllers.Sessions.ModelsOut;

public class GetUserLoggedSessionResponse
{
    public string Id { get; }
    public string? VisitorId { get; }
    public List<string> Roles { get; }

    public GetUserLoggedSessionResponse(User? user)
    {
        Id = user.Id.ToString();
        VisitorId = user.VisitorProfileId?.ToString();
        Roles = user.Roles.Select(r => r.Name).ToList();
    }
}
