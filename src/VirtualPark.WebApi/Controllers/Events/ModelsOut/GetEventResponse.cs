using VirtualPark.BusinessLogic.Events.Entity;

namespace VirtualPark.WebApi.Controllers.Events.ModelsOut;

public sealed class GetEventResponse
{
    public string Id { get; }
    public string Name { get; }
    public string Date { get; }
    public string Capacity { get; }
    public string Cost { get; }
    public List<string> Attractions { get; }
    public string TicketsSold { get; }

    public GetEventResponse(Event ev)
    {
        Id = ev.Id.ToString();
        Name = ev.Name;
        Date = ev.Date.ToString("yyyy-MM-dd");
        Capacity = ev.Capacity.ToString();
        Cost = ev.Cost.ToString();
        Attractions = ev.Attractions.Select(a => a.Id.ToString()).ToList();
        TicketsSold = ev.Tickets?.Count.ToString() ?? "0";
    }
}
