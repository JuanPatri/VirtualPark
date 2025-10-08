using Microsoft.EntityFrameworkCore;
using VirtualPark.BusinessLogic.Permissions.Entity;

namespace VirtualPark.DataAccess.Seed;

public static class AttractionSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Key = "CreateAttraction-Attraction",
                Description = "Allows creating new attractions"
            },
            new Permission
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111112"),
                Key = "GetAttractionById-Attraction",
                Description = "Allows retrieving details of a specific attraction"
            },
            new Permission
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111113"),
                Key = "GetAllAttractions-Attraction",
                Description = "Allows listing all available attractions"
            },
            new Permission
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111114"),
                Key = "UpdateAttraction-Attraction",
                Description = "Allows modifying an existing attraction"
            },
            new Permission
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111115"),
                Key = "DeleteAttraction-Attraction",
                Description = "Allows deleting an existing attraction"
            }
        );
    }
}
