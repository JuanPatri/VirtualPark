using Microsoft.EntityFrameworkCore;

namespace VirtualPark.DataAccess.Seed;

public class SeedData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        AttractionSeed.Seed(modelBuilder);
        EventSeed.Seed(modelBuilder);
        ClockAppSeed.Seed(modelBuilder);
        IncidenceSeed.Seed(modelBuilder);
        PermissionSeed.Seed(modelBuilder);
        RankingSeed.Seed(modelBuilder);
        RoleSeed.Seed(modelBuilder);
        TicketSeed.Seed(modelBuilder);
        TypeIncidenceSeed.Seed(modelBuilder);
        UserSeed.Seed(modelBuilder);
        VisitorProfileSeed.Seed(modelBuilder);
        RolePermissionSeed.Seed(modelBuilder);
    }
}
