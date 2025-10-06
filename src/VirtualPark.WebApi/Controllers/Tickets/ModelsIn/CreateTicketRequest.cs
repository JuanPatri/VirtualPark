namespace VirtualPark.WebApi.Controllers.Tickets.ModelsIn;

public sealed class CreateTicketRequest(string visitorId, string type, string? eventId)
{
    public string VisitorId { get; set; } = visitorId;
    public string Type { get; set; } = type;
    public string? EventId { get; set; } = eventId;
}
