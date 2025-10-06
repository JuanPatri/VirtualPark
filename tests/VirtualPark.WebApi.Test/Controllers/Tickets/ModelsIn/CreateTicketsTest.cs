namespace VirtualPark.WebApi.Test.Controllers.Tickets.ModelsIn;

[TestClass]
[TestCategory("ModelsIn")]
public sealed class CreateTicketRequestTest
{
    [TestClass]
    [TestCategory("ModelsIn")]
    public sealed class CreateTicketRequestTest
    {
        #region Success
        [TestMethod]
        [TestCategory("Conversion")]
        public void ToArgs_WhenValidData_ShouldReturnTicketArgs()
        {
            var visitorId = Guid.NewGuid();
            var type = EntranceType.Event.ToString();
            var eventId = Guid.NewGuid();
            var date = "2025-10-10";

            var request = new CreateTicketRequest
            {
                VisitorId = visitorId.ToString(),
                Type = type,
                EventId = eventId.ToString(),
                Date = date
            };

            var result = request.ToArgs();

            result.VisitorId.Should().Be(visitorId);
            result.Type.Should().Be(EntranceType.Event);
            result.EventId.Should().Be(eventId);
        }
        #endregion
}
