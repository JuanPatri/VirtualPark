namespace VirtualPark.BusinessLogic.Permissions;

public class Permission
{
    public Guid Id { get; }

    public Permission()
    {
        Id = Guid.NewGuid();
    }
}
