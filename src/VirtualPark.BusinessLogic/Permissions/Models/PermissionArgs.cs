namespace VirtualPark.BusinessLogic.Permissions.Models;

public sealed class PermissionArgs(string description, string key, List<Guid> roles)
{
    public string Description { get; set; } = ValidateNullOrEmpty(description);
    public string Key { get; set; } = key;
    public List<Guid> Roles { get; set; } = roles;

    private static string ValidateNullOrEmpty(string value)
    {
        if(string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Value cannot be null or empty.");
        }

        return value;
    }
}
