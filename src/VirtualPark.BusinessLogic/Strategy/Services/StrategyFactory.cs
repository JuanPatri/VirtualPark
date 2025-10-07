using System.Collections.ObjectModel;

namespace VirtualPark.BusinessLogic.Strategy.Services;
public sealed class StrategyFactory : IStrategyFactory
{
    private readonly IReadOnlyDictionary<string, IStrategy> _map;

    public StrategyFactory(IEnumerable<IStrategy> strategies)
}
