namespace VirtualPark.BusinessLogic.Events.Models;

public sealed class EventsArgs(string name)
{
    public string Name { get; init; } = ValidateName(name);

    private static string ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Invalid event name");
        }

        return name;
    }
}
