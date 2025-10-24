namespace VirtualPark.WebApi.Controllers.VisitsScore.ModelsIn;

public class VisitScoreRequest
{
    public string? VisitRegistrationId { get; init; }
    public string? Origin { get; init; }
    public string? Points { get; init; }
}
