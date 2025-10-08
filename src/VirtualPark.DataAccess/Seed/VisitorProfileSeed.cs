using Microsoft.EntityFrameworkCore;
using VirtualPark.BusinessLogic.Permissions.Entity;

namespace VirtualPark.DataAccess.Seed;

public static class VisitorProfileSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission
            {
                Id = Guid.Parse("12121212-1111-1111-1111-111111111111"),
                Key = "GetVisitorProfileById-VisitorProfile",
                Description = "Allows retrieving a visitor profile by ID"
            },
            new Permission
            {
                Id = Guid.Parse("12121212-1111-1111-1111-111111111112"),
                Key = "GetAllVisitorProfiles-VisitorProfile",
                Description = "Allows listing all visitor profiles"
            });
    }
}
