using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.BusinessLogic.Rewards.Models;

public sealed class RewardArgs(string name, string description)
{
    public string Name { get; } = ValidationServices.ValidateNullOrEmpty(name);
    public string Description { get; } = ValidationServices.ValidateNullOrEmpty(description);
}
