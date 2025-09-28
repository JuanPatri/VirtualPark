using VirtualPark.BusinessLogic.Validations.Services;
using VirtualPark.BusinessLogic.VisitorsProfile.Entity;

namespace VirtualPark.BusinessLogic.VisitorsProfile.Models;

public class VisitorProfileArgs(string dateOfBirth, string membership)
{
    public DateOnly DateOfBirth { get; init; } = ValidationServices.ParseDateOfBirth(dateOfBirth);
    public Membership Membership { get; init; } = ParseMembership(membership);

    private static Membership ParseMembership(string membership)
    {
        var isNotValid = !Enum.TryParse<Membership>(membership, true, out var parsedMembership);
        if(isNotValid)
        {
            throw new ArgumentException(
                $"Invalid membership value: {membership}",
                nameof(membership));
        }

        return parsedMembership;
    }
}
