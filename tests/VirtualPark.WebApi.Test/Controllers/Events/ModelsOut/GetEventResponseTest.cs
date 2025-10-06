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
            id,
            "Halloween Party",
            new DateTime(2025, 10, 31, 20, 0, 0),
            200,
            1500,
            new List<EventAttractionResponse>());

        response.Id.Should().Be(id);
    }
    #endregion
}
