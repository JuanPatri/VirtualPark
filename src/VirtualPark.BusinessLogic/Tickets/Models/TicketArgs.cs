using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.BusinessLogic.Tickets.Models;

public sealed class TicketArgs(string date, string type, string eventId, Guid visitorId)
{
    public DateOnly Date { get; } = ValidationServices.ValidateDateOnly(date);

    public EntranceType Type { get; } = ValidationServices.ParseEntranceType(type);

    public Guid EventId { get; } = ValidateAndParseGuid(eventId);
    public Guid VisitorId { get; } = visitorId;

    private static Guid ValidateAndParseGuid(string value)
    {
        if(string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Value cannot be null or empty.");
        }

        if(!Guid.TryParse(value, out var result))
        {
            throw new FormatException($"The value '{value}' is not a valid GUID.");
        }

        return result;
    }
}
