using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.BusinessLogic.VisitsScore.Models;

public sealed class RecordVisitScoreArgs(string visitRegistrationId, string origin, string? points = null)
{
    public Guid VisitRegistrationId { get; init; } = ValidationServices.ValidateAndParseGuid(visitRegistrationId);
    public string Origin { get; init; } = ValidationServices.ValidateNullOrEmpty(origin).Trim();
    public int? Points { get; init; } = string.IsNullOrWhiteSpace(points) ? null : ValidationServices.ValidateAndParseInt(points);
}
