using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.BusinessLogic.Tickets.Models;

public sealed class TicketArgs(string date, string type, Guid eventId, Guid visitorId)
{
    public DateOnly Date { get; } = ValidationServices.ValidateDateOnly(date);

    public EntranceType Type { get; } = ValidationServices.ParseEntranceType(type);

    public Guid EventId { get; } = eventId;
    public Guid VisitorId { get; } = visitorId;
}
