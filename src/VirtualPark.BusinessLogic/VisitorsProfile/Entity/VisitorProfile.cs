namespace VirtualPark.BusinessLogic.VisitorsProfile.Entity;

public class VisitorProfile
{
    public Guid Id { get; init; }

    public VisitorProfile()
    {
        Id = Guid.NewGuid();
    }
}
