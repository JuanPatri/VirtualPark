using Microsoft.EntityFrameworkCore;
using VirtualPark.BusinessLogic.Permissions.Entity;

namespace VirtualPark.DataAccess.Seed;

public static class RankingSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission
            {
                Id = Guid.Parse("88888888-1111-1111-1111-111111111111"),
                Key = "GetRanking-Ranking",
                Description = "Allows retrieving a specific ranking by date and period"
            },
            new Permission
            {
                Id = Guid.Parse("88888888-1111-1111-1111-111111111112"),
                Key = "GetAllRankings-Ranking",
                Description = "Allows listing all rankings stored in the system"
            });
    }
}
