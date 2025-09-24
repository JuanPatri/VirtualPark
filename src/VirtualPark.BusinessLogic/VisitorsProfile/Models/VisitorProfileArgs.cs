using VirtualPark.BusinessLogic.Visitors.Entity;

namespace VirtualPark.BusinessLogic.VisitorsProfile.Models;

public class VisitorProfileArgs
{
    public DateOnly DateOfBirth { get; init; }
    public Membership Membership { get; init; }
}
