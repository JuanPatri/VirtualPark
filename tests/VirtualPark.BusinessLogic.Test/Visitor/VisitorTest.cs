namespace VirtualPark.BusinessLogic.Test.Visitor;

[TestClass]
[TestCategory("Entity")]
[TestCategory("Visitor")]
public class VisitorTest
{
    [TestMethod]
    [TestCategory("Constructor")]
    public void WhenVisitorIsCreated_IdShouldBeAssigned()
    {
        // Act
        var visitor = new Visitor();

        // Assert
        visitor.Id.Should().NotBe(Guid.Empty);
    }
}
