using FluentAssertions;
using VirtualPark.BusinessLogic.Attractions.Entity;
using VirtualPark.BusinessLogic.Events;

namespace VirtualPark.BusinessLogic.Test.Events.Entity;

[TestClass]
[TestCategory("Entity")]
[TestCategory("Events")]
public sealed class EventTest
{
    #region ID
    [TestMethod]
    public void WhenEventIsCreated_IdIsAssigned()
    {
        var newEvent = new EventTest();
        newEvent.Id.Should().NotBe(Guid.Empty);
    }
    #endregion

}
