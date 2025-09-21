namespace VirtualPark.BusinessLogic.VisitorsProfile.Entity;

public class VisitorProfile
{
    public Guid Id { get; init; }
    public DateOnly DateOfBirth { get; set; }

    public VisitorProfile()
    {
        Id = Guid.NewGuid();
    }
}
