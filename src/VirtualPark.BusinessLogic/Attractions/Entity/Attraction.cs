namespace VirtualPark.BusinessLogic.Attractions.Entity;

public sealed class Attraction
{
    public Guid Id { get; init; }

    public Attraction()
    {
        Id = Guid.NewGuid();
    }
}
