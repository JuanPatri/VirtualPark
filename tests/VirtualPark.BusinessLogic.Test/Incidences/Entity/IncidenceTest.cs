using FluentAssertions;
using VirtualPark.BusinessLogic.Incidences.Entity;

namespace VirtualPark.BusinessLogic.Test.Incidences.Entity;

[TestClass]
[TestCategory("Entity")]
[TestCategory("Incidence")]
public class IncidenceTest
{
    #region Id
    [TestMethod]
    [TestCategory("Validation")]
    public void Incidence_WhenCreated_ShouldHaveNonEmptyId()
    {
        var incidence = new Incidence();
        incidence.Id.Should().NotBe(Guid.Empty);
    }
    #endregion
}
