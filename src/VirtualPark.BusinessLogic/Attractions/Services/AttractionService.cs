using VirtualPark.BusinessLogic.Attractions.Entity;
using VirtualPark.BusinessLogic.Attractions.Models;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.Attractions.Services;

public sealed class AttractionService(IRepository<Attraction> attractionRepository)
{
    private readonly IRepository<Attraction> _attractionRepository = attractionRepository;

    public Attraction Create(AttractionArgs args)
    {
        ValidateAttractionName(args.Name);

        var attraction = new Attraction
        {
            Name = args.Name,
            Type = args.Type,
            Description = args.Description,
            MiniumAge = args.MiniumAge,
            Capacity = args.Capacity,
            CurrentVisitors = args.CurrentVisitor,
            Available = args.Available
        };

        _attractionRepository.Add(attraction);

        return attraction;
    }
}
