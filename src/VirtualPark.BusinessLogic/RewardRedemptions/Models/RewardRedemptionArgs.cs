using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.BusinessLogic.RewardRedemptions.Models;

public sealed class RewardRedemptionArgs(string rewardId, string visitorId)
{
    public Guid RewardId { get; } = ValidationServices.ValidateAndParseGuid(rewardId);
    public Guid VisitorId { get; } = ValidationServices.ValidateAndParseGuid(visitorId);
}
