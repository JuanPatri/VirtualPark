using FluentAssertions;

namespace VirtualPark.BusinessLogic.Test.RewardRedemption.Entity;
using VirtualPark.BusinessLogic.RewardRedemption.Entity;

[TestClass]
[TestCategory("Entity")]
public sealed class RewardRedemptionTest
{
    [TestMethod]
    [TestCategory("Success")]
    public void Constructor_WhenRewardIdIsValid_ShouldSetRewardId()
    {
        var rewardId = Guid.NewGuid();

        var redemption = new RewardRedemption { RewardId = rewardId };

        redemption.RewardId.Should().Be(rewardId);
    }
}
