namespace VirtualPark.BusinessLogic.Test.TypeIncidences.Entity;

[TestClass]
[TestCategory("Entity")]
[TestCategory("TypeIncidence")]
public class TypeIncidenceTest
{
    [TestMethod]
    [TestCategory("Validation")]
    public void Visitor_WhenCreated_ShouldHaveNonEmptyId()
    {
        var typeIncidence = new TypeIncidence();
        typeIncidence.Id.Should().NotBe(System.Guid.Empty);
    }
}
