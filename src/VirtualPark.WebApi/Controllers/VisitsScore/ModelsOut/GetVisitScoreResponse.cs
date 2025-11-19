using VirtualPark.BusinessLogic.VisitsScore.Entity;

namespace VirtualPark.WebApi.Controllers.VisitsScore.ModelsOut;

public class GetVisitScoreResponse
{
    public string Id { get; }
    public string Origin { get; }
    public string OccurredAt { get; }
    public int Points { get; }
    public string? DayStrategyName { get; }
    public string VisitRegistrationId { get; }

    public GetVisitScoreResponse(VisitScore score)
    {
        Id = score.Id.ToString();
        Origin = score.Origin;
        OccurredAt = score.OccurredAt
            .ToUniversalTime()
            .ToString("O");
        Points = score.Points;
        DayStrategyName = score.DayStrategyName;
        VisitRegistrationId = score.VisitRegistrationId.ToString();
    }
}
