namespace VirtualPark.BusinessLogic.Roles.Entity;
using Permissions.Entity;

public class Role
{
    public Role()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; }
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
    public List<Permission> Permissions { get; set; } = new();
}
