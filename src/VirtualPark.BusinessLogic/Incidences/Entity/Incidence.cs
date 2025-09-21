namespace VirtualPark.BusinessLogic.Incidences.Entity;

public class Incidence
{
    public Guid Id { get; }

    public Incidence()
    {
        Id = Guid.NewGuid();
    }
}
