using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.BusinessLogic.Sessions.Models;

public class SessionArgs(string userId)
{
    public Guid UserId { get; init; } = ValidationServices.ValidateAndParseGuid(userId);
}
