namespace VirtualPark.BusinessLogic.TypeIncidences.Entity;

public class TypeIncidence
{
    public Guid Id { get; set; }

    public TypeIncidence()
    {
        Id = Guid.NewGuid();
    }
}
