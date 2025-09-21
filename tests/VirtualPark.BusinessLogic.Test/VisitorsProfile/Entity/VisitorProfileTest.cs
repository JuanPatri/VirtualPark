using FluentAssertions;
using VirtualPark.BusinessLogic.VisitorsProfile.Entity;

namespace VirtualPark.BusinessLogic.Test.VisitorsProfile.Entity;

[TestClass]
[TestCategory("Entity")]
[TestCategory("VisitorProfile")]
public class VisitorProfileTest
{
    [TestMethod]
    [TestCategory("Validation")]
    public void User_createdShouldBeHaveId()
    {
        var visitorProfile = new VisitorProfile();
        visitorProfile.Id.Should().NotBe(System.Guid.Empty);
    }
}
