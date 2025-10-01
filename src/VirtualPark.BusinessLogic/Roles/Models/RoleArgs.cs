using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.BusinessLogic.Roles.Models;

public sealed class RoleArgs(string name, string description)
{
    public string Name { get; init; } = ValidationServices.ValidateNullOrEmpty(name);
    public string Description { get; set; } = ValidationServices.ValidateNullOrEmpty(description);
}
