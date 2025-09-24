namespace VirtualPark.BusinessLogic.Test.Events.Modules;

[TestClass]
[TestCategory("Models")]
[TestCategory("EventsArgsTest")]
public class EventsArgsTest
{
    public void Name_Getter_ReturnsAssignedValue()
    {
        var eventsArgs = new EventsArgs("Halloween");
        EventArgs.Should().Be("Halloween");
    }
}
