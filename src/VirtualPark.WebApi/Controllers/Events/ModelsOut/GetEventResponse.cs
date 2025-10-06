namespace VirtualPark.WebApi.Controllers.Events.ModelsOut;

public sealed class GetEventResponse(string id, string name)
{
    public string Id { get; } = id;
    public string Name { get; } = name;
}
