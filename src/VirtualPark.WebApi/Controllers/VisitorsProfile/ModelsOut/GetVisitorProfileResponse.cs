using VirtualPark.BusinessLogic.VisitorsProfile.Entity;

namespace VirtualPark.WebApi.Controllers.VisitorsProfile.ModelsOut;

public class GetVisitorProfileResponse
{
    public string Id { get; }
    public string DateOfBirth { get; }
    public string Membership { get; }
    public string Score { get; }
    public string NfcId { get; }
    public string PointsAvailable { get; }

    public GetVisitorProfileResponse(VisitorProfile vp)
    {
        Id = vp.Id.ToString();
        DateOfBirth = vp.DateOfBirth.ToString("yyyy-MM-dd");
        Membership = vp.Membership.ToString();
        Score = vp.Score.ToString();
        NfcId = vp.NfcId.ToString();
        PointsAvailable = vp.PointsAvailable.ToString();
    }
}
