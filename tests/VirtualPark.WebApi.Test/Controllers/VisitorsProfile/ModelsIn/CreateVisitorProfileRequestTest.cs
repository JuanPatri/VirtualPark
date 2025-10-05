using FluentAssertions;
using VirtualPark.WebApi.Controllers.VisitorsProfile.ModelsIn;

namespace VirtualPark.WebApi.Test.Controllers.VisitorsProfile.ModelsIn;

[TestClass]
[TestCategory("ModelsIn")]
[TestCategory("CreateVisitorProfileRequest")]
public class CreateVisitorProfileRequestTest
{
    #region DateOfBirth
    [TestMethod]
    [TestCategory("Validation")]
    public void DateOfBirth_Getter_ReturnsAssignedValue()
    {
        var createVisitorProfileRequest = new CreateVisitorProfileRequest { DateOfBirth = "2002-07-30" };
        createVisitorProfileRequest.DateOfBirth.Should().Be("2002-07-30");
    }
    #endregion
}
