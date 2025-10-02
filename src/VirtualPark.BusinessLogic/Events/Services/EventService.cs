using System.Linq.Expressions;
using VirtualPark.BusinessLogic.Attractions.Entity;
using VirtualPark.BusinessLogic.Attractions.Services;
using VirtualPark.BusinessLogic.Events.Entity;
using VirtualPark.BusinessLogic.Events.Models;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.Events.Services;

public class EventService(IRepository<Event> repository, AttractionService attractionService)
{
    private readonly IRepository<Event> _repository = repository;
    private readonly AttractionService _attractionService = attractionService;

    public Guid Create(EventsArgs args)
    {
        var entity = MapToEntity(args);
        _repository.Add(entity);
        return entity.Id;
    }

    private Event MapToEntity(EventsArgs args)
    {
        List<Attraction> attractions = MapAttractionsList(args.AttractionIds);
        Event @event = new Event
        {
            Name = args.Name,
            Date = args.Date.ToDateTime(TimeOnly.MinValue),
            Capacity = args.Capacity,
            Cost = args.Cost,
            Attractions = attractions
        };
        return @event;
    }

    private List<Attraction> MapAttractionsList(List<Guid> argsAttractionIds)
    {
        var attractions = new List<Attraction>();

        foreach (var id in argsAttractionIds)
        {
            var attraction = _attractionService.Get(a => a.Id == id);

            if (attraction is null)
            {
                throw new InvalidOperationException($"Attraction with id {id} not found.");
            }

            attractions.Add(attraction);
        }

        return attractions;
    }

    public Event? Get(Expression<Func<Event, bool>> predicate)
    {
       return _repository.Get(predicate);
    }
}
