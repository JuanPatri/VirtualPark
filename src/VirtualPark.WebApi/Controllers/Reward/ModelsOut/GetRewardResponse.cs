namespace VirtualPark.WebApi.Controllers.Reward.ModelsOut;

public class GetRewardResponse
{
    public string Id { get; }
    public string Name { get; }
    public string Description { get; }
    public string Cost { get; }
    public string QuantityAvailable { get; }
    public string Membership { get; }

    public GetRewardResponse(BusinessLogic.Rewards.Entity.Reward reward)
    {
        Id = reward.Id.ToString();
        Name = reward.Name;
        Description = reward.Description;
        Cost = reward.Cost.ToString();
        QuantityAvailable = reward.QuantityAvailable.ToString();
        Membership = reward.RequiredMembershipLevel.ToString();
    }
}
