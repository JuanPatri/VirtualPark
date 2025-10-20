namespace VirtualPark.BusinessLogic.Test.Reward.Models;

[TestClass]
[TestCategory("Args")]
public sealed class RewardArgsTest
{
    [TestMethod]
    [TestCategory("Validation")]
    public void Constructor_WhenNameIsValid_ShouldSetName()
    {
        var name = "VIP Ticket";

        var args = new RewardArgs { Name = name };

        args.Name.Should().Be(name);
    }
}
