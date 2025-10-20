using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.BusinessLogic.RewardRedemptions.Models;

public sealed class RewardRedemptionArgs(string rewardId)
{
    public Guid RewardId { get; } = ValidationServices.ValidateAndParseGuid(rewardId);
}
