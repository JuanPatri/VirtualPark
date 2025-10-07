using FluentAssertions;
using VirtualPark.BusinessLogic.Sessions.Models;

namespace VirtualPark.BusinessLogic.Test.Sessions.Models;

[TestClass]
[TestCategory("Models")]
[TestCategory("SessionArgs")]
public class SessionArgsTest
{
    #region Email
    [TestMethod]
    [TestCategory("Validation")]
    public void Email_Getter_ReturnsAssignedValue()
    {
        var sessionArgs = new SessionArgs("email@gmail.com");
        sessionArgs.Email.Should().Be("email@gmail.com");
    }
    #endregion
}
