using Moq;
using VirtualPark.BusinessLogic.Tickets;
using VirtualPark.BusinessLogic.Tickets.Entity;
using VirtualPark.WebApi.Controllers.Tickets.ModelsOut;

namespace VirtualPark.WebApi.Test.Controllers.Tickets
{
    [TestClass]
    public sealed class TicketControllerTest
    {
        private Mock<ITicketService> _ticketServiceMock = null!;
        private TicketController _controller = null!;

        [TestInitialize]
        public void Initialize()
        {
            _ticketServiceMock = new(MockBehavior.Strict);
            _controller = new TicketController(_ticketServiceMock.Object);
        }

        #region Get
        [TestMethod]
        [TestCategory("Behaviour")]
        public void GetTicketById_ValidInput_ShouldReturnGetTicketResponse()
        {
            var visitorId = Guid.NewGuid();
            var eventId = Guid.NewGuid();
            var ticket = new Ticket
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2025, 12, 15),
                Type = EntranceType.Event,
                EventId = eventId,
                VisitorProfileId = visitorId,
                QrId = Guid.NewGuid()
            };

            _ticketServiceMock
                .Setup(s => s.Get(ticket.Id))
                .Returns(ticket);

            var result = _controller.GetTicketById(ticket.Id.ToString());

            result.Should().NotBeNull();
            result.Should().BeOfType<GetTicketResponse>();
            result.Id.Should().Be(ticket.Id.ToString());
            result.Type.Should().Be(ticket.Type.ToString());
            result.Date.Should().Be(ticket.Date.ToString("yyyy-MM-dd"));
            result.EventId.Should().Be(ticket.EventId.ToString());
            result.QrId.Should().Be(ticket.QrId.ToString());
            result.VisitorId.Should().Be(visitorId.ToString());

            _ticketServiceMock.VerifyAll();
        }
        #endregion
    }
}

