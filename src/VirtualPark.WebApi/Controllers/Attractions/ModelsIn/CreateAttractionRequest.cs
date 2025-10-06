using VirtualPark.BusinessLogic.Attractions.Models;
using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.WebApi.Controllers.Attractions.ModelsIn;

public sealed class CreateAttractionRequest
{
    public string? Name { get; init; }
    public string? Type { get; init; }
    public string? MiniumAge { get; init; }
    public string? Capacity { get; init; }
    public string? Description { get; init; }
    public string? Available { get; init; }
}
