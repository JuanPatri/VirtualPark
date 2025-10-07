namespace VirtualPark.WebApi.Test.Controllers.Ranking.ModelsOut;

[TestClass]
[TestCategory("GetRankingResponse")]
public sealed class GetRankingResponseTest
{
    private static GetRankingResponse Build(
        string? id = null,
        string? date = null,
        List<string>? users = null,
        string? period = null)
    {
        return new GetRankingResponse(
            id: id ?? Guid.NewGuid().ToString(),
            date: date ?? "2025-10-06",
            users: users ?? [Guid.NewGuid().ToString(), Guid.NewGuid().ToString()],
            period: period ?? "Daily");
    }

    #region Id
    [TestMethod]
    [TestCategory("Validation")]
    public void GetRankingResponse_IdProperty_ShouldMatchCtorValue()
    {
        var id = Guid.NewGuid().ToString();
        var response = Build(id: id);
        response.Id.Should().Be(id);
    }
    #endregion
}
