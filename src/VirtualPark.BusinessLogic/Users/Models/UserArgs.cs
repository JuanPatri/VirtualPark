using VirtualPark.BusinessLogic.Validations.Services;
using VirtualPark.BusinessLogic.VisitorsProfile.Models;

namespace VirtualPark.BusinessLogic.Users.Models;

public class UserArgs(string name, string lastName, string email, string password)
{
    public string Name { get; init; } = name;
    public string LastName { get; init; } = lastName;
    public string Email { get; init; } = ValidationServices.ValidateEmail(email);
    public string Password { get; init; } = ValidationServices.ValidatePassword(password);
    public VisitorProfileArgs? VisitorProfile { get; set; }
}
