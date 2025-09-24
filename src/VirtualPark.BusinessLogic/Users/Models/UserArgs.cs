using System.Net.Mail;
using System.Text.RegularExpressions;
using VirtualPark.BusinessLogic.VisitorsProfile.Models;

namespace VirtualPark.BusinessLogic.Users.Models;

public class UserArgs
{
    public string Name { get; init; } = null!;
    public string LastName { get; init; } = null!;
    public string Email { get; init; } = null!;
    public string Password { get; init; } = null!;
    public VisitorProfileArgs? VisitorProfile { get; set; }

    public UserArgs(string name, string lastName, string email, string password)
    {
        Name = name;
        LastName = lastName;
        try
        {
            var ok = new MailAddress(email);
            Email = email;
        }
        catch
        {
            throw new ArgumentException($"Invalid email format: {email}", nameof(email));
        }

        var regex = new Regex(@".{8,}$");
        var isNotValid = !regex.IsMatch(password);
        if (isNotValid)
        {
            throw new ArgumentException(
                "Password must be at least 8 characters long and contain uppercase, lowercase, digit, and special character.",
                nameof(password)
            );
        }

        Password = password;
    }
}
