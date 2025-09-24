using FluentAssertions;
using VirtualPark.BusinessLogic.Validations.Services;

namespace VirtualPark.BusinessLogic.Test.Validations;

[TestClass]
[TestCategory("Validations")]
public class ValidationTest
{
    private ValidationServices _validationServices = null!;
    [TestInitialize]
    public void Initialize()
    {
        _validationServices = new ValidationServices();
    }

    [TestMethod]
    [TestCategory("Validations")]
    public void ParseToInt_WhenInputIsValid_ShouldReturnInteger()
    {
        var number = _validationServices.ValidateAndParseInt("123");
        number.Type.Should().Be(123);
    }
}
