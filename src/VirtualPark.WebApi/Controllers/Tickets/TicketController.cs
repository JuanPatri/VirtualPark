using Microsoft.AspNetCore.Mvc;
using VirtualPark.BusinessLogic.Tickets.Entity;
using VirtualPark.BusinessLogic.Tickets.Service;
using VirtualPark.BusinessLogic.Validations.Services;
using VirtualPark.WebApi.Controllers.Tickets.ModelsOut;

namespace VirtualPark.WebApi.Controllers.Tickets;

[ApiController]
public sealed class TicketController(ITicketService ticketService) : ControllerBase
{
    private readonly ITicketService _ticketService = ticketService;

    [HttpGet("/tickets/{id}")]
    public GetTicketResponse GetTicketById(string id)
    {
        Guid ticketId = ValidationServices.ValidateAndParseGuid(id);
        Ticket ticket = _ticketService.Get(ticketId)!;

        return new GetTicketResponse(
            ticket.Id.ToString(),
            ticket.Type.ToString(),
            ticket.Date.ToString("yyyy-MM-dd"),
            eventId: ticket.EventId.ToString(),
            qrId: ticket.QrId.ToString(),
            visitorId: ticket.VisitorProfileId.ToString());
    }
}
