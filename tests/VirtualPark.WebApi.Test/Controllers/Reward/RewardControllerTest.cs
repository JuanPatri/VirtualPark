namespace VirtualPark.WebApi.Test.Controllers.Reward;

[TestClass]
public sealed class RewardControllerTest
{
    [TestMethod]
    public void CreateReward_ValidInput_ReturnsCreatedRewardResponse()
    {
        var returnId = Guid.NewGuid();

        var request = new CreateRewardRequest
        {
            Name = "VIP Ticket",
            Description = "Priority Access",
            PointsRequired = "1500",
            QuantityAvailable = "25",
            Membership = "VIP"
        };

        var expectedArgs = request.ToArgs();

        _rewardServiceMock
            .Setup(s => s.Create(It.Is<RewardArgs>(a =>
                a.Name == expectedArgs.Name &&
                a.Description == expectedArgs.Description &&
                a.PointsRequired == expectedArgs.PointsRequired &&
                a.QuantityAvailable == expectedArgs.QuantityAvailable &&
                a.Membership == expectedArgs.Membership)))
            .Returns(returnId);

        var response = _rewardController.CreateReward(request);

        response.Should().NotBeNull();
        response.Should().BeOfType<CreateRewardResponse>();
        response.Id.Should().Be(returnId.ToString());

        _rewardServiceMock.VerifyAll();
    }
}
