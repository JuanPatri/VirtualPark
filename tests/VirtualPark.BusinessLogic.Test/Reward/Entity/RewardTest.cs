namespace VirtualPark.BusinessLogic.Test.Reward.Entity;

[TestClass]
[TestCategory("Entity")]
public sealed class RewardTest
{
    [TestMethod]
    [TestCategory("Success")]
    public void Constructor_WhenNameIsValid_ShouldSetName()
    {
        const string name = "Entrada VIP";

        var reward = new Reward(name);

        reward.Name.Should().Be(name);
    }
}
