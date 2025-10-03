using VirtualPark.BusinessLogic.ClocksApp.Entity;
using VirtualPark.BusinessLogic.ClocksApp.Models;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.ClocksApp.Service;

public class ClockAppService : IClockAppService
{
    private readonly IRepository<ClockApp> _clockAppRepository;

    private ClockApp GetOCreate()
    {
        var clock = _clockAppRepository.GetAll().FirstOrDefault();
        if(clock is null)
        {
            clock = new ClockApp();
            _clockAppRepository.Add(clock);
        }

        return clock;
    }

    public ClockAppService(IRepository<ClockApp> clockAppRepository)
    {
        _clockAppRepository = clockAppRepository;
    }

    public int CalculateDifferenceInMinutes(DateTime systemDateTime)
    {
        return (int)Math.Round((systemDateTime - DateTime.Now).TotalMinutes);
    }

    public DateTime Now()
    {
        throw new NotImplementedException();
    }
}
