using FluentAssertions;
using VirtualPark.BusinessLogic.Sessions.Models;

namespace VirtualPark.BusinessLogic.Test.Sessions.Models;

[TestClass]
[TestCategory("Models")]
[TestCategory("SessionArgs")]
public class SessionArgsTest
{
    #region UserId
    [TestMethod]
    [TestCategory("Validation")]
    public void UserId_Getter_ReturnsAssignedValue()
    {
        var guid = Guid.NewGuid();
        var sessionArgs = new SessionArgs(guid.ToString());
        sessionArgs.UserId.Should().Be(guid);
    }
    #endregion
}
