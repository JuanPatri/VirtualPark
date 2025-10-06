namespace VirtualPark.WebApi.Controllers.Tickets.ModelsOut;

public sealed class GetTicketResponse(string id, string type)
{
    public string Id { get; } = id;
    public string Type { get; } = type;
}
