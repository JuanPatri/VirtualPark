using FluentAssertions;
using VirtualPark.WebApi.Controllers.VisitsScore.ModelsOut;

namespace VirtualPark.WebApi.Test.Controllers.VisitsScore.ModelsOut;

[TestClass]
[TestCategory("ModelsOut")]
[TestCategory("GetVisitScoreResponse")]
public class GetVisitScoreResponseTest
{
    #region Id
    [TestMethod]
    [TestCategory("Validation")]
    public void Id_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();
        var regId = Guid.NewGuid().ToString();

        var resp = new GetVisitScoreResponse(
            id,
            "Attraction",
            "2025-10-08T12:00:00.0000000Z",
            42);

        resp.Id.Should().Be(id);
    }
    #endregion

    #region Origin
    [TestMethod]
    [TestCategory("Validation")]
    public void Origin_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();
        var regId = Guid.NewGuid().ToString();

        var resp = new GetVisitScoreResponse(
            id,
            "Attraction",
            "2025-10-08T12:00:00.0000000Z",
            42);

        resp.Origin.Should().Be("Attraction");
    }
    #endregion

    #region OccurredAt
    [TestMethod]
    [TestCategory("Validation")]
    public void OccurredAt_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();
        var regId = Guid.NewGuid().ToString();
        var occurred = "2025-10-08T12:00:00.0000000Z";

        var resp = new GetVisitScoreResponse(
            id,
            "Attraction",
            occurred,
            42);

        resp.OccurredAt.Should().Be(occurred);
    }
    #endregion

    #region Points
    [TestMethod]
    [TestCategory("Validation")]
    public void Points_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();
        var regId = Guid.NewGuid().ToString();

        var resp = new GetVisitScoreResponse(
            id,
            "Attraction",
             "2025-10-08T12:00:00.0000000Z",
            42);

        resp.Points.Should().Be(42);
    }
    #endregion
}
