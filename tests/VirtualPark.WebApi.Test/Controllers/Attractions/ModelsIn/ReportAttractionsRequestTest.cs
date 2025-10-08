namespace VirtualPark.WebApi.Test.Controllers.Attractions.ModelsIn;

[TestClass]
[TestCategory("CreateAttractionRequest")]
public class ReportAttractionsRequestTest
{
    #region From

    [TestMethod]
    public void ReportAttractionRequest_NameProperty_GetAndSet_ShouldWorkCorrectly()
    {
        var attraction = new ReportAttractionRequest { From = "2025-04-23" };
        attraction.From.Should().Be("2025-04-23");
    }
    #endregion
}
