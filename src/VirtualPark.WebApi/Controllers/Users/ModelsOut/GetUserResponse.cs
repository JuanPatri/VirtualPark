using VirtualPark.BusinessLogic.Users.Entity;

namespace VirtualPark.WebApi.Controllers.Users.ModelsOut;

public class GetUserResponse
{
    public string Id { get; }
    public string Name { get; }
    public string LastName { get; }
    public string Email { get; }
    public List<string> Roles { get; }
    public string? VisitorProfileId { get; }

    public GetUserResponse(User user)
    {
        Id = user.Id.ToString();
        Name = user.Name;
        LastName = user.LastName;
        Email = user.Email;
        Roles = user.Roles?
            .Select(r => r.Id.ToString())
            .ToList() ?? [];

        VisitorProfileId = user.VisitorProfileId?.ToString();
    }
}
