namespace VirtualPark.BusinessLogic.TypeIncidences.Entity;

public class TypeIncidence
{
    public Guid Id { get; }
    public string Type { get; init; } = null!;

    public TypeIncidence()
    {
        Id = Guid.NewGuid();
    }
}
