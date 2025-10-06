namespace VirtualPark.WebApi.Controllers.Tickets.ModelsIn;

public sealed class CreateTicketRequest(string visitorId)
{
    public string VisitorId { get; set; } = visitorId;
}
