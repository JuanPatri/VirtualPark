using VirtualPark.BusinessLogic.TypeIncidences.Entity;

namespace VirtualPark.WebApi.Controllers.TypeIncidences.ModelsOut;

public class GetTypeIncidenceResponse
{
    public string Id { get; }
    public string Type { get; }

    public GetTypeIncidenceResponse(TypeIncidence typeIncidence)
    {
        Id = typeIncidence.Id.ToString();
        Type = typeIncidence.Type;
    }
}
