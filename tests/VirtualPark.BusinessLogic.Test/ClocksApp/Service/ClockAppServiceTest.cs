using FluentAssertions;
using VirtualPark.BusinessLogic.ClocksApp.Service;

namespace VirtualPark.BusinessLogic.Test.ClocksApp.Service;

[TestClass]
[TestCategory("ClockAppService")]
public class ClockAppServiceTest
{
    private ClockAppService _clockAppService = null!;

    [TestInitialize]
    public void Initialize()
    {
        _clockAppService = new ClockAppService();
    }

    #region CalculateDifferenceInMinutes
    [TestMethod]
    public void CalculateDifferenceInMinutes_WhenSameDateTime_ShouldReturnZero()
    {
        var now = DateTime.Now;

        var result = _clockAppService.CalculateDifferenceInMinutes(now);

        result.Should().Be(0);
    }

    [TestMethod]
    public void CalculateDifferenceInMinutes_WhenFutureDateTime_ShouldReturnPositive()
    {
        var future = DateTime.Now.AddMinutes(30);

        var result = _clockAppService.CalculateDifferenceInMinutes(future);

        result.Should().Be(30);
    }

    [TestMethod]
    public void CalculateDifferenceInMinutes_WhenPastDateTime_ShouldReturnNegative()
    {
        var past = DateTime.Now.AddMinutes(-45);

        var result = _clockAppService.CalculateDifferenceInMinutes(past);

        result.Should().Be(-45);
    }

    #endregion
}
