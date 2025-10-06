namespace VirtualPark.WebApi.Controllers.Tickets.ModelsOut;

public sealed class GetTicketResponse(string id, string type, string date, string qrId)
{
    public string Id { get; } = id;
    public string Type { get; } = type;
    public string Date { get; } = date;
    public string QrId { get; } = qrId;
}
