using FluentAssertions;
using VirtualPark.WebApi.Controllers.Incidences.ModelsOut;

namespace VirtualPark.WebApi.Test.Controllers.Incidences.ModelsOut;
[TestClass]
public class GetIncidenceResponseTest
{
    #region Id
    [TestMethod]
    [TestCategory("Validation")]
    public void Id_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();
        var response = new GetIncidenceResponse(id);
        response.Id.Should().Be(id);
    }
    #endregion
}
