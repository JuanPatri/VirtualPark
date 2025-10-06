namespace VirtualPark.WebApi.Controllers.Events.ModelsIn;

public sealed class CreateEventRequest
{
    public string? Name { get; init; }
    public string? Date { get; init; }
}
