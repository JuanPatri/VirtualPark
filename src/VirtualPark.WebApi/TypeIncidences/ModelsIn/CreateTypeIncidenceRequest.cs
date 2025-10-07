using VirtualPark.BusinessLogic.TypeIncidences.Models;
using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.WebApi.TypeIncidences.ModelsIn;

public class CreateTypeIncidenceRequest
{
    public string? Type { get; init; }
}
