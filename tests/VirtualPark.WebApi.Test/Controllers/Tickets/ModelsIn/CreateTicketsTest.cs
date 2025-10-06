using FluentAssertions;
using VirtualPark.BusinessLogic.Tickets;
using VirtualPark.WebApi.Controllers.Tickets.ModelsIn;

namespace VirtualPark.WebApi.Test.Controllers.Tickets.ModelsIn;

[TestClass]
[TestCategory("ModelsIn")]
[TestCategory("CreateTicketRequest")]
public class CreateTicketRequestTest
{
    #region VisitorId
    [TestMethod]
    [TestCategory("Validation")]
    public void VisitorId_Getter_ShouldReturnAssignedValue()
    {
        var guid = Guid.NewGuid().ToString();
        var request = new CreateTicketRequest(guid, EntranceType.Event.ToString(), Guid.NewGuid().ToString());
        request.VisitorId.Should().Be(guid);
    }
    #endregion

    #region Type
    [TestMethod]
    [TestCategory("Validation")]
    public void Type_Getter_ShouldReturnAssignedValue()
    {
        var request = new CreateTicketRequest(Guid.NewGuid().ToString(), EntranceType.General.ToString(), Guid.NewGuid().ToString());
        request.Type.Should().Be("General");
    }
    #endregion

    #region EventId
    [TestMethod]
    [TestCategory("Validation")]
    public void EventId_Getter_ShouldReturnAssignedValue()
    {
        var guid = Guid.NewGuid().ToString();
        var request = new CreateTicketRequest(Guid.NewGuid().ToString(), EntranceType.General.ToString(), guid );
        request.EventId.Should().Be(guid);
    }
    #endregion
}
