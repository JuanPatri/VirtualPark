namespace VirtualPark.WebApi.Controllers.RewardRedemption.ModelsIn;

public sealed class CreateRewardRedemptionRequest
{
    public string? RewardId { get; init; }
    public string? VisitorId { get; init; }
    public string? Date { get; set; }
    public string? PointsSpent { get; set; }
}
