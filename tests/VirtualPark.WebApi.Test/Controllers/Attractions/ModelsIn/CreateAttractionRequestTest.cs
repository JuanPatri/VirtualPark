using FluentAssertions;

namespace VirtualPark.WebApi.Test.Controllers.Attractions.ModelsIn;

public class CreateAttractionRequestTest
{
    #region Name

    [TestMethod]
    public void CreateAttractionRequest_NameProperty_GetAndSet_ShouldWorkCorrectly()
    {
        var attraction = new CreateAttractionRequestTest { Name = "Titanic" };
        attraction.Name.Should().Be("Titanic");
    }
    #endregion
}
