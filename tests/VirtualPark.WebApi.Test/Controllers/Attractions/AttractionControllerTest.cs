using FluentAssertions;
using Moq;
using VirtualPark.BusinessLogic.Attractions.Models;
using VirtualPark.BusinessLogic.Attractions.Services;
using VirtualPark.WebApi.Controllers.Attractions;
using VirtualPark.WebApi.Controllers.Attractions.ModelsIn;
using VirtualPark.WebApi.Controllers.Attractions.ModelsOut;

namespace VirtualPark.WebApi.Test.Controllers.Attractions;

[TestClass]
[TestCategory("AttractionsController")]
public class AttractionControllerTest
{
    private Mock<IAttractionService> _attractionService = null!;
    private AttractionController _attractionController = null!;
    private CreateAttractionRequest _createAttractionRequest = null!;

    [TestInitialize]
    public void Initialize()
    {
        _attractionService = new Mock<IAttractionService>(MockBehavior.Strict);
        _attractionController = new AttractionController(_attractionService.Object);
        _createAttractionRequest = new CreateAttractionRequest
        {
            Name = "AttractionName",
            Type = "RollerCoaster",
            MiniumAge = "18",
            Capacity = "50",
            Description = "AttractionDescription",
            Available = "true"
        };
    }

    #region Create

    [TestMethod]
    public void Create_ValidInput_ReturnsCreatedAttractionResponse()
    {
        var returnId = Guid.NewGuid();
        var expectedArgs = _createAttractionRequest.ToArgs();

        _attractionService
            .Setup(s => s.Create(It.Is<AttractionArgs>(a =>
                a.Name == expectedArgs.Name &&
                a.Type == expectedArgs.Type &&
                a.MiniumAge == expectedArgs.MiniumAge &&
                a.Capacity == expectedArgs.Capacity &&
                a.Description == expectedArgs.Description &&
                a.Available == expectedArgs.Available)))
            .Returns(returnId);

        var response = _attractionController.Create(_createAttractionRequest);

        response.Should().NotBeNull();
        response.Should().BeOfType<CreateAttractionResponse>();
        response.Id.Should().Be(returnId.ToString());

        _attractionService.VerifyAll();
    }

    [TestMethod]
    public void Create_ShouldWork_WhenAvailableIsFalse()
    {
        var returnId = Guid.NewGuid();
        var request = new CreateAttractionRequest
        {
            Name = "AttractionName",
            Type = "RollerCoaster",
            MiniumAge = "18",
            Capacity = "50",
            Description = "AttractionDescription",
            Available = "false"
        };

        var expectedArgs = request.ToArgs();

        _attractionService
            .Setup(s => s.Create(It.Is<AttractionArgs>(a =>
                a.Name == expectedArgs.Name &&
                a.Type == expectedArgs.Type &&
                a.MiniumAge == expectedArgs.MiniumAge &&
                a.Capacity == expectedArgs.Capacity &&
                a.Description == expectedArgs.Description &&
                a.Available == expectedArgs.Available)))
            .Returns(returnId);

        var response = _attractionController.Create(request);

        response.Should().NotBeNull();
        response.Should().BeOfType<CreateAttractionResponse>();
        response.Id.Should().Be(returnId.ToString());

        _attractionService.VerifyAll();
    }

    #endregion

}
