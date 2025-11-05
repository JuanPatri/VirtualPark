using VirtualPark.BusinessLogic.VisitRegistrations.Entity;

namespace VirtualPark.ReflectionAbstractions;

public interface IStrategy
{
    string Key { get; }
    int CalculatePoints(VisitRegistration visitRegistration);
}
