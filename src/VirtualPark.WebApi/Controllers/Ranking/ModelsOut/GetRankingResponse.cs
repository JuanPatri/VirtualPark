namespace VirtualPark.WebApi.Controllers.Ranking.ModelsOut;

public sealed class GetRankingResponse
{
    public string Id { get; }
    public string Date { get; }
    public List<string> Users { get; }
    public List<string> Scores { get; }
    public string Period { get; }

    public GetRankingResponse(BusinessLogic.Rankings.Entity.Ranking? ranking)
    {
        Id = ranking.Id.ToString();
        Date = ranking.Date.ToString("yyyy-MM-dd");

        Users = ranking.Entries
            .Select(e => e.Id.ToString())
            .ToList();

        Scores = ranking.Entries
            .Select(e => (e.VisitorProfile?.Score ?? 0).ToString())
            .ToList();

        Period = ranking.Period.ToString();
    }
}
