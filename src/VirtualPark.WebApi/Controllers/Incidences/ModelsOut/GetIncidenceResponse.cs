namespace VirtualPark.WebApi.Controllers.Incidences.ModelsOut;

public class GetIncidenceResponse(string id)
{
    public string Id { get; set; } = id;
}
