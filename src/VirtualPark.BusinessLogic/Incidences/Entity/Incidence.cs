using VirtualPark.BusinessLogic.TypeIncidences.Entity;

namespace VirtualPark.BusinessLogic.Incidences.Entity;

public class Incidence
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public TypeIncidence Type { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime Start { get; set; }
}
