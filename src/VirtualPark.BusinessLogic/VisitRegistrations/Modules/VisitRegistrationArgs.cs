namespace VirtualPark.BusinessLogic.VisitRegistrations.Modules;

public sealed class VisitRegistrationArgs(string date)
{
    public string Date { get; init; } = ValidateDate(date);

    private static string ValidateDate(string date)
    {
        if(!DateOnly.TryParseExact(date, "yyyy-MM-dd", out var parsedDate))
        {
            throw new ArgumentException(
                $"Invalid date format: {date}. Expected format is yyyy-MM-dd");
        }

        return date;
    }
}
