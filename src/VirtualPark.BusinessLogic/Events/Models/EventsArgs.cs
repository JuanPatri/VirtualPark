using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.BusinessLogic.Events.Models;

public sealed class EventsArgs(string name, string date, int capacity, int cost, List<String> attractionsIds)
{
    public string Name { get; init; } = ValidationServices.ValidateNullOrEmpty(name);
    public DateOnly Date { get; init; } = ValidationServices.ValidateDateOnly(date);
    public int Capacity { get; set; } = ValidatePositive(capacity);
    public int Cost { get; set; } = ValidatePositive(cost);
    public List<Guid> AttractionIds { get; init; } = ValidateAttractionList(attractionsIds);

    private static List<Guid> ValidateAttractionList(List<string> attractionIds)
    {
        if (attractionIds is null)
        {
            throw new ArgumentException("Attraction IDs list cannot be null.");
        }

        if (!attractionIds.Any())
        {
            throw new ArgumentException("Attraction IDs list cannot be empty.");
        }

        return attractionIds.Select(Guid.Parse).ToList();
    }

    private static int ValidatePositive(int number)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(number);

        return number;
    }
}
