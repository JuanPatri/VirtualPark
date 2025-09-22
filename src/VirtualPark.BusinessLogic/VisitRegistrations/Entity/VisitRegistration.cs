using VirtualPark.BusinessLogic.Attractions.Entity;
namespace VirtualPark.BusinessLogic.VisitRegistrations.Entity;

public sealed class VisitRegistration
{
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime Date { get; set; } = DateTime.Today;
    public List<Attraction> Attractions { get; set; } = [];
}
