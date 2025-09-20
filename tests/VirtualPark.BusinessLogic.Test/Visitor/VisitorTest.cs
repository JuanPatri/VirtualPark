using FluentAssertions;
using VirtualPark.BusinessLogic.Visitors.Entity;

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

    [TestMethod]
    [TestCategory("Validation")]
    public void SetDateOfBirth_WhenValueIsInFuture_ShouldThrowArgumentException()
    {
        // Arrange
        var futureDate = DateTime.UtcNow.AddDays(1);

        // Act
        var ex = Assert.ThrowsException<ArgumentException>(() =>
        {
            var dummy = new Visitor { DateOfBirth = futureDate };
        });

        // Assert
        Assert.AreEqual("Date of birth cannot be in the future", ex.Message);
    }
}
