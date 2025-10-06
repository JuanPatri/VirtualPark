using FluentAssertions;
using VirtualPark.WebApi.Controllers.Incidences.ModelsIn;

namespace VirtualPark.WebApi.Test.Controllers.Incidences.ModelsIn;

[TestClass]
public class CreateIncidenceRequestTest
{
    #region Type
    [TestMethod]
    [TestCategory("Validation")]
    public void Name_Getter_ReturnsAssignedValue()
    {
        var typeId = Guid.NewGuid().ToString();
        var createIncidenceRequest = new CreateIncidenceRequest { TypeId = typeId };
        createIncidenceRequest.TypeId.Should().Be(typeId);
    }
    #endregion
    #region Description

    [TestMethod]
    [TestCategory("Validation")]
    public void Description_Getter_ReturnsAssignedValue()
    {
        var createIncidenceRequest = new CreateIncidenceRequest { Description = "Description" };
        createIncidenceRequest.Description.Should().Be("Description");
    }
    #endregion
    #region Start

    [TestMethod]
    [TestCategory("Validation")]
    public void Start_Getter_ReturnsAssignedValue()
    {
        var createIncidenceRequest = new CreateIncidenceRequest { Start = "2025-10-06T18:45:00" };
        createIncidenceRequest.Start.Should().Be("2025-10-06T18:45:00");
    }
    #endregion
    #region End

    [TestMethod]
    [TestCategory("Validation")]
    public void End_Getter_ReturnsAssignedValue()
    {
        var createIncidenceRequest = new CreateIncidenceRequest { End = "2025-10-06T18:45:00" };
        createIncidenceRequest.End.Should().Be("2025-10-06T18:45:00");
    }
    #endregion
    #region Attraction
    [TestMethod]
    [TestCategory("Validation")]
    public void Attraction_Getter_ReturnsAssignedValue()
    {
        var attractionID = Guid.NewGuid().ToString();
        var createIncidenceRequest = new CreateIncidenceRequest { AttractionId = attractionID };
        createIncidenceRequest.AttractionId.Should().Be(attractionID);
    }
    #endregion
    #region Active

    [TestMethod]
    [TestCategory("Validation")]
    public void Active_Getter_ReturnsAssignedValue()
    {
        var createIncidenceRequest = new CreateIncidenceRequest { Active = "true" };
        createIncidenceRequest.Active.Should().Be("true");
    }
    #endregion
}
