using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.BusinessLogic.Sessions.Models;

public class SessionArgs(string email)
{
    public string Email { get; init; } = ValidationServices.ValidateEmail(email);
}
