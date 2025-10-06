using FluentAssertions;
using VirtualPark.WebApi.Controllers.Events.ModelsOut;

namespace VirtualPark.WebApi.Test.Controllers.Events.ModelsOut;

[TestClass]
[TestCategory("ModelsOut")]
[TestCategory("GetEventResponse")]
public class GetEventResponseTest
{
    #region Id
    [TestMethod]
    [TestCategory("Validation")]
    public void Id_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();
        var response = new GetEventResponse(
            id, "Halloween");

        response.Id.Should().Be(id);
    }
    #endregion

    #region Name
    [TestMethod]
    [TestCategory("Validation")]
    public void Name_Getter_ReturnsAssignedValue()
    {
        var response = new GetEventResponse(
            Guid.NewGuid().ToString(),
            "Halloween Party");
        response.Name.Should().Be("Halloween Party");
    }
    #endregion

    #region Date
    [TestMethod]
    [TestCategory("Validation")]
    public void Date_Getter_ReturnsAssignedValue()
    {
        var date = new DateTime(2025, 10, 31, 20, 0, 0);
        var response = new GetEventResponse(
            Guid.NewGuid().ToString(),
            "Halloween Party",
            date);
        response.Date.Should().Be(date);
    }
    #endregion
}
