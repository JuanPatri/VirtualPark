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
    public void Visitor_Birthday_ShouldBeInvalid_WhenSetInFuture()
    {
        // Arrange
        var futureDate = DateTime.UtcNow.AddDays(1);

        // Act
        Action act = () => new Visitor { DateOfBirth = futureDate };

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("Date of birth must not be in the future.");
    }
}
