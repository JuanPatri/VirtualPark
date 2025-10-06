using FluentAssertions;
using VirtualPark.WebApi.Controllers.VisitorsProfile.ModelsOut;

namespace VirtualPark.WebApi.Test.Controllers.VisitorsProfile.ModelsOut;

[TestClass]
[TestCategory("ModelsOut")]
[TestCategory("GetVisitorProfileResponse")]
public class GetVisitorProfileResponseTest
{
    #region Id
    [TestMethod]
    [TestCategory("Validation")]
    public void Id_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();
        var response = new GetVisitorProfileResponse(
            id);
        response.Id.Should().Be(id);
    }
    #endregion
}
