namespace VirtualPark.WebApi.Test.Controllers.Events.ModelsOut;

public class CreateEventResponseTest
{
    #region Id
    [TestMethod]
    [TestCategory("Validation")]
    public void Id_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();
        var response = new CreateEventResponse(id);
        response.Id.Should().Be(id);
    }
    #endregion
}
