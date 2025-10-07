using FluentAssertions;
using VirtualPark.WebApi.Controllers.Users.ModelsOut;
using VirtualPark.WebApi.TypeIncidences.ModelsOut;

namespace VirtualPark.WebApi.Test.TypeIncidences.ModelsOut;

[TestClass]
[TestCategory("ModelsOut")]
[TestCategory("GetTypeIncidenceResponse")]
public class GetTypeIncidenceResponseTest
{
    #region Id
    [TestMethod]
    [TestCategory("Validation")]
    public void Id_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();
        var response = new GetTypeIncidenceResponse(
            id);
        response.Id.Should().Be(id);
    }
    #endregion
}
