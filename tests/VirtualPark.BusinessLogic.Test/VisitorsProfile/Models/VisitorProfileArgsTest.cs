using FluentAssertions;
using VirtualPark.BusinessLogic.Visitors.Entity;
using VirtualPark.BusinessLogic.VisitorsProfile.Models;

namespace VirtualPark.BusinessLogic.Test.VisitorsProfile.Models;

[TestClass]
[TestCategory("Models")]
[TestCategory("VisitorProfileArgsTest")]
public class VisitorProfileArgsTest
{
    #region DateOfBirth
    [TestMethod]
    [TestCategory("Validation")]
    public void DateOfBirth_Getter_ReturnsAssignedValue()
    {
        var visitorProfileArgs = new VisitorProfileArgs("2002-07-30", "Standard" );
        visitorProfileArgs.DateOfBirth.Should().Be(new DateOnly(2002, 07, 30));
    }
    #endregion

    #region Membership
    [TestMethod]
    [TestCategory("Validation")]
    public void Membership_Getter_ReturnsAssignedValue()
    {
        var visitorProfileArgs = new VisitorProfileArgs("2002-07-30", "Standard");
        visitorProfileArgs.Membership.Should().Be(Membership.Standard);
    }
    #endregion
}
