namespace VirtualPark.WebApi.Controllers.Events.ModelsOut;

public sealed class GetEventResponse(string id)
{
    public string Id { get; } = id;
}
