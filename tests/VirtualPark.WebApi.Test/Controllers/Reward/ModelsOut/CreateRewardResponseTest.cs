namespace VirtualPark.WebApi.Test.Controllers.Reward.ModelsOut;

[TestClass]
[TestCategory("ModelsOut")]
[TestCategory("CreateRewardResponse")]
public class CreateRewardResponseTest
{
    [TestMethod]
    [TestCategory("Validation")]
    public void Id_Getter_ReturnsAssignedValue()
    {
        var id = Guid.NewGuid().ToString();

        var response = new CreateRewardResponse(id);

        response.Id.Should().Be(id);
    }
}
