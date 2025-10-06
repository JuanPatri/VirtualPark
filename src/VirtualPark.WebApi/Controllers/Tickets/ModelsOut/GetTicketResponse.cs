namespace VirtualPark.WebApi.Controllers.Tickets.ModelsOut;

public class GetTicketResponse(string id)
{
    public string Id { get; } = id;
}
