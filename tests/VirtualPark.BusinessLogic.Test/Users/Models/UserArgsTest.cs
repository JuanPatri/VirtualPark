using FluentAssertions;
using VirtualPark.BusinessLogic.Users.Models;

namespace VirtualPark.BusinessLogic.Test.Users.Models;

[TestClass]
[TestCategory("Models")]
[TestCategory("UserArgs")]
public class UserArgsTest
{
    #region Name
    [TestMethod]
    [TestCategory("Validation")]
    public void Name_Getter_ReturnsAssignedValue()
    {
        var userArgs = new UserArgs { Name = "Pepe" };
        userArgs.Name.Should().Be("Pepe");
    }
    #endregion

    [TestMethod]
    [TestCategory("Validation")]
    public void LastName_ShouldBeGettable()
    {
        var userArgs = new UserArgs { LastName = "Perez" };
        userArgs.LastName.Should().Be("Perez");
    }
}
