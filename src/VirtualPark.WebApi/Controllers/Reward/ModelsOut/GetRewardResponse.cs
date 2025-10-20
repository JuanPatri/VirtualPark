namespace VirtualPark.WebApi.Controllers.Reward.ModelsOut;

public class GetRewardResponse(string id, string name, string description)
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string Description { get; } = description;
}
