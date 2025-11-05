using VirtualPark.BusinessLogic.Attractions;
using VirtualPark.BusinessLogic.Attractions.Entity;
using VirtualPark.BusinessLogic.Sessions.Entity;
using VirtualPark.BusinessLogic.Sessions.Service;
using VirtualPark.ReflectionAbstractions;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.Strategy.Services;

public class AttractionPointsStrategy(ISessionService sessionService) : IStrategy
{
    private readonly ISessionService _sessionService = sessionService;
    public string Key { get; } = "Attraction";

    public int CalculatePoints()
    {
        var visitorProfile = _sessionService.GetUserLogged();
        if(visit.Attractions.Count == 0)
        {
            return 0;
        }

        var totalPoints = 0;

        foreach(var attraction in visit.Attractions)
        {
            totalPoints += attraction.Type switch
            {
                AttractionType.RollerCoaster => 50,
                AttractionType.Show => 30,
                AttractionType.Simulator => 20,
                _ => 10
            };
        }

        return totalPoints;
    }
}
