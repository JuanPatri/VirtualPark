using FluentAssertions;
using Moq;
using VirtualPark.BusinessLogic.Rewards.Models;
using VirtualPark.BusinessLogic.Rewards.Service;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.Test.Reward.Service;
using VirtualPark.BusinessLogic.Rewards.Entity;

[TestClass]
[TestCategory("Service")]
[TestCategory("RewardService")]
public sealed class RewardServiceTest
{
    private Mock<IRepository<Reward>> _rewardRepositoryMock = null!;
    private RewardService _rewardService = null!;

    [TestInitialize]
    public void Initialize()
    {
        _rewardRepositoryMock = new Mock<IRepository<Reward>>(MockBehavior.Strict);
        _rewardService = new RewardService(_rewardRepositoryMock.Object);
    }

    [TestMethod]
    [TestCategory("Validation")]
    public void Create_WhenArgsAreValid_ShouldReturnRewardId()
    {
        var args = new RewardArgs("VIP Ticket", "Access to all rides", "200", "5", "Standard");

        _rewardRepositoryMock
            .Setup(r => r.Add(It.Is<Reward>(rw =>
                rw.Name == args.Name &&
                rw.Description == args.Description &&
                rw.Cost == args.Cost &&
                rw.QuantityAvailable == args.QuantityAvailable &&
                rw.RequiredMembershipLevel == args.RequiredMembershipLevel)));

        Guid result = _rewardService.Create(args);

        result.Should().NotBeEmpty();

        _rewardRepositoryMock.VerifyAll();
    }
}
