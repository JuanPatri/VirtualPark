namespace VirtualPark.WebApi.Controllers.Incidences.ModelsOut;

public class GetIncidenceResponse(string id, string typeId)
{
    public string Id { get; init; } = id;
    public string TypeId { get; init; } = typeId;
}
