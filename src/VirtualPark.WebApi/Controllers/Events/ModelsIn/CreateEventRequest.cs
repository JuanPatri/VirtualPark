using VirtualPark.BusinessLogic.Events.Models;
using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.WebApi.Controllers.Events.ModelsIn;

public sealed class CreateEventRequest
{
    public List<String>? AttractionsIds { get; init; }
    public string? Capacity { get; init; }
    public string? Cost { get; init; }
    public string? Date { get; init; }
    public string? Name { get; init; }

    public EventsArgs ToArgs()
    {
        return new EventsArgs(
            ValidationServices.ValidateNullOrEmpty(Name),
            ValidationServices.ValidateNullOrEmpty(Date),
            ValidationServices.ValidatePositive(int.Parse(ValidationServices.ValidateNullOrEmpty(Capacity))),
            ValidationServices.ValidatePositive(int.Parse(ValidationServices.ValidateNullOrEmpty(Cost))),
            AttractionsIds ?? throw new ArgumentException("Attractions list cannot be null"));
    }
}
