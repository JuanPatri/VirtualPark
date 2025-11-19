using VirtualPark.BusinessLogic.Strategy.Entity;
using VirtualPark.BusinessLogic.Strategy.Models;

namespace VirtualPark.WebApi.Controllers.Strategy.ModelsOut;

public class GetActiveStrategyResponse
{
    public string Key { get; }
    public string Date { get; }

    public GetActiveStrategyResponse(ActiveStrategyArgs? strategy)
    {
        Key = strategy.StrategyKey;
        Date = strategy.Date.ToString("yyyy-MM-dd");
    }
}
