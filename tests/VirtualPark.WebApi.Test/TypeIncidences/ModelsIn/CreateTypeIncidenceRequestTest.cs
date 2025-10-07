using FluentAssertions;
using VirtualPark.WebApi.TypeIncidences.ModelsIn;

namespace VirtualPark.WebApi.Test.TypeIncidences.ModelsIn;

[TestClass]
[TestCategory("ModelsIn")]
[TestCategory("CreateTypeIncidenceRequest")]
public class CreateTypeIncidenceRequestTest
{
    #region Type
    [TestMethod]
    [TestCategory("Validation")]
    public void Type_Getter_ReturnsAssignedValue()
    {
        var createTypeIncidenceRequest = new CreateTypeIncidenceRequest() { Type = "type" };
        createTypeIncidenceRequest.Type.Should().Be("type");
    }
    #endregion
}
