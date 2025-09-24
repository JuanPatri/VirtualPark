using FluentAssertions;
using VirtualPark.BusinessLogic.Users.Models;

namespace VirtualPark.BusinessLogic.Test.Users.Models;

[TestClass]
[TestCategory("Models")]
[TestCategory("UserArgs")]
public class UserArgsTest
{
    [TestMethod]
    [TestCategory("Validation")]
    public void Name_shouldBeGettable()
    {
        var userArgs = new UserArgs { Name = "Pepe" };
        userArgs.Name.Should().Be("Pepe");
    }
}
