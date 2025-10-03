using FluentAssertions;
using Moq;
using VirtualPark.BusinessLogic.ClocksApp.Entity;
using VirtualPark.BusinessLogic.ClocksApp.Models;
using VirtualPark.BusinessLogic.ClocksApp.Service;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.Test.ClocksApp.Service;

[TestClass]
[TestCategory("ClockAppService")]
public class ClockAppServiceTest
{
    private ClockAppService _clockAppService = null!;
    private Mock<IRepository<ClockApp>> _clockAppRepository = null!;
    private ClockAppArgs _clockArgs = null!;

    [TestInitialize]
    public void Initialize()
    {
        _clockAppRepository = new Mock<IRepository<ClockApp>>(MockBehavior.Strict);
        _clockAppService = new ClockAppService(_clockAppRepository.Object);
        _clockArgs = new ClockAppArgs("2025-10-02 18:30");
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
