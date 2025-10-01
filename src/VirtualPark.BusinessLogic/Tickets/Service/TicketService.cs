using VirtualPark.BusinessLogic.Tickets.Entity;
using VirtualPark.BusinessLogic.Tickets.Models;
using VirtualPark.BusinessLogic.VisitorsProfile.Service;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.Tickets.Service;

public class TicketService(IRepository<Ticket> ticketRepository, VisitorProfileService visitorProfileService)
{
    private readonly IRepository<Ticket> _ticketRepository = ticketRepository;
    private readonly VisitorProfileService _visitorProfileService = visitorProfileService;

    public Ticket Create(TicketArgs args)
    {
        Ticket ticket = new Ticket();
        ticket.Date = args.Date;
        ticket.Type = args.Type;
        ticket.EventId = args.EventId;
        ticket.Visitor = _visitorProfileService.Get(args.VisitorId);
        _ticketRepository.Add(ticket);
        return ticket;
    }
}
