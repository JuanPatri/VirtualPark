using FluentAssertions;
using VirtualPark.WebApi.Controllers.Permissions.ModelsIn;

namespace VirtualPark.WebApi.Test.Controllers.Permissions.ModelsIn;

[TestClass]
[TestCategory("ModelsIn")]
[TestCategory("CreatePermissionRequest")]
public class CreatePermissionRequestTest
{
    [TestMethod]
    [TestCategory("Validation")]
    public void Description_Getter_ReturnsAssignedValue()
    {
        var createPermissionRequest = new CreatePermissionRequest { Description = "Pepe" };
        createPermissionRequest.Description.Should().Be("Pepe");
    }
}
