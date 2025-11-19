using VirtualPark.BusinessLogic.Permissions.Entity;

namespace VirtualPark.WebApi.Controllers.Permissions.ModelsOut;

public class GetPermissionResponse
{
    public string Id { get; }
    public string Description { get; }
    public string Key { get; }
    public List<string> Roles { get; }

    public GetPermissionResponse(Permission permission)
    {
        Id = permission.Id.ToString();
        Description = permission.Description;
        Key = permission.Key;
        Roles = permission.Roles
            .Select(r => r.Id.ToString())
            .ToList();
    }
}
