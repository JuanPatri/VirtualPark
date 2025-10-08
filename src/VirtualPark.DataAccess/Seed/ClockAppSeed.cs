using Microsoft.EntityFrameworkCore;
using VirtualPark.BusinessLogic.Permissions.Entity;

namespace VirtualPark.DataAccess.Seed;

public static class ClockAppSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission
            {
                Id = Guid.Parse("55555555-1111-1111-1111-111111111111"),
                Key = "GetClock-ClockApp",
                Description = "Allows retrieving the current system clock"
            },
            new Permission
            {
                Id = Guid.Parse("55555555-1111-1111-1111-111111111112"),
                Key = "UpdateClock-ClockApp",
                Description = "Allows updating the global system clock"
            });
    }
}
