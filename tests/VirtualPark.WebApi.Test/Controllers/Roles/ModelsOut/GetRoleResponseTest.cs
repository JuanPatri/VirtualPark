using FluentAssertions;
using VirtualPark.WebApi.Controllers.Roles.ModelsOut;

namespace VirtualPark.WebApi.Test.Controllers.Roles.ModelsOut;

[TestClass]
[TestCategory("ModelsOut")]
[TestCategory("GetRoleResponse")]
public class GetRoleResponseTest
{
    #region Id
    [TestMethod]
    [TestCategory("Validation")]
    public void Id_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();
        var response = new GetRoleResponse(
            id,
            "Admin",
            "Full access",
            [Guid.NewGuid().ToString()],
            [Guid.NewGuid().ToString()]
        );

        response.Id.Should().Be(id);
    }
    #endregion
}
