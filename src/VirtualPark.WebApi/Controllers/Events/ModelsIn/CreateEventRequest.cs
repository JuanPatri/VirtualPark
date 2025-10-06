namespace VirtualPark.WebApi.Controllers.Events.ModelsIn;

public sealed class CreateEventRequest
{
    public List<String>? AttractionsIds { get; init; }
    public string? Capacity { get; init; }
    public string? Cost { get; init; }
    public string? Date { get; init; }
    public string? Name { get; init; }
}
