using FluentAssertions;
using VirtualPark.BusinessLogic.Events.Entity;

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
        var newEvent = new Event();
        newEvent.Id.Should().NotBe(Guid.Empty);
    }
    #endregion
    #

}
