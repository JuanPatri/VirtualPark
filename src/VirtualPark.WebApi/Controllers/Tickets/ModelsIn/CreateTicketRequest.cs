namespace VirtualPark.WebApi.Controllers.Tickets.ModelsIn;

public sealed class CreateTicketRequest(string visitorId, string type)
{
    public string VisitorId { get; set; } = visitorId;
    public string Type { get; set; } = type;
}
