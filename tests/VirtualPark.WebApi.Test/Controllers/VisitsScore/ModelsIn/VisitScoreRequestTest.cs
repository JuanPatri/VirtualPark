using FluentAssertions;
using VirtualPark.WebApi.Controllers.VisitsScore.ModelsIn;

namespace VirtualPark.WebApi.Test.Controllers.VisitsScore.ModelsIn;

[TestClass]
[TestCategory("ModelsIn")]
[TestCategory("VisitScoreRequest")]
public class VisitScoreRequestTest
{
    #region VisitRegistrationId
    [TestMethod]
    [TestCategory("Getter")]
    public void VisitRegistrationId_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();
        var req = new VisitScoreRequest { VisitRegistrationId = id };
        req.VisitRegistrationId.Should().Be(id);
    }
    #endregion

    #region Origin
    [TestMethod]
    [TestCategory("Getter")]
    public void Origin_Getter_ReturnsAssignedValue()
    {
        var req = new VisitScoreRequest { Origin = "Atracción" };
        req.Origin.Should().Be("Atracción");
    }
    #endregion

    #region Points
    [TestMethod]
    [TestCategory("Getter")]
    public void Points_Getter_ReturnsAssignedValue()
    {
        var req = new VisitScoreRequest { Points = "-30" };
        req.Points.Should().Be("-30");
    }
    #endregion
}
