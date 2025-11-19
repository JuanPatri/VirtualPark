using VirtualPark.BusinessLogic.Roles.Entity;

namespace VirtualPark.WebApi.Controllers.Roles.ModelsOut;

public class GetRoleResponse
{
    public string Id { get; }
    public string Name { get; }
    public string Description { get; }
    public List<string> PermissionIds { get; }
    public List<string> UsersIds { get; }

    public GetRoleResponse(Role role)
    {
        Id = role.Id.ToString();
        Name = role.Name;
        Description = role.Description;
        PermissionIds = role.Permissions
            .Select(p => p.Id.ToString())
            .ToList();
        UsersIds = role.Users
            .Select(u => u.Id.ToString())
            .ToList();
    }
}
