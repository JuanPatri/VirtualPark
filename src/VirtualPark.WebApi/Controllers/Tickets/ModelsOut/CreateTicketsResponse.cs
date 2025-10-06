namespace VirtualPark.WebApi.Controllers.Tickets.ModelsOut;

public sealed class CreateTicketResponse
{
    public CreateTicketResponse(string id)
    {
        Id = id;
    }

    public string Id { get; init; }
}
