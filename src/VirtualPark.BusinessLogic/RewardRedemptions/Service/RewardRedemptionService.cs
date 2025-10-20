using VirtualPark.BusinessLogic.RewardRedemptions.Entity;
using VirtualPark.BusinessLogic.RewardRedemptions.Models;
using VirtualPark.BusinessLogic.Rewards.Entity;
using VirtualPark.BusinessLogic.VisitorsProfile.Entity;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.RewardRedemptions.Service;

public sealed class RewardRedemptionService(
    IRepository<Reward> rewardRepository,
    IRepository<RewardRedemption> redemptionRepository,
    IRepository<VisitorProfile> visitorRepository)
{
    private readonly IRepository<Reward> _rewardRepository = rewardRepository;
    private readonly IRepository<RewardRedemption> _redemptionRepository = redemptionRepository;
    private readonly IRepository<VisitorProfile> _visitorRepository = visitorRepository;

    public Guid RedeemReward(RewardRedemptionArgs args)
    {
        var reward = _rewardRepository.Get(rw => rw.Id == args.RewardId);
        var visitor = _visitorRepository.Get(v => v.Id == args.VisitorId);

        reward!.QuantityAvailable--;
        visitor!.Score -= args.PointsSpent;

        var redemption = new RewardRedemption
        {
            RewardId = args.RewardId,
            VisitorId = args.VisitorId,
            Date = args.Date,
            PointsSpent = args.PointsSpent
        };

        _redemptionRepository.Add(redemption);
        _rewardRepository.Update(reward);
        _visitorRepository.Update(visitor);

        return redemption.Id;
    }
}
