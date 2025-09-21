namespace VirtualPark.BusinessLogic.Events.Entity;

public sealed class Event
{
    public Guid Id { get; set; } = Guid.NewGuid();
}
