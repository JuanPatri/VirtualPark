using Microsoft.EntityFrameworkCore;
using VirtualPark.BusinessLogic.Permissions.Entity;

namespace VirtualPark.DataAccess.Seed;

public static class IncidenceSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission
            {
                Id = Guid.Parse("66666666-1111-1111-1111-111111111111"),
                Key = "CreateIncidence-Incidence",
                Description = "Allows reporting or creating a new incidence"
            },
            new Permission
            {
                Id = Guid.Parse("66666666-1111-1111-1111-111111111112"),
                Key = "GetIncidence-Incidence",
                Description = "Allows retrieving details of a specific incidence"
            },
            new Permission
            {
                Id = Guid.Parse("66666666-1111-1111-1111-111111111113"),
                Key = "GetAllIncidences-Incidence",
                Description = "Allows listing all registered incidences"
            },
            new Permission
            {
                Id = Guid.Parse("66666666-1111-1111-1111-111111111114"),
                Key = "UpdateIncidence-Incidence",
                Description = "Allows updating an existing incidence"
            },
            new Permission
            {
                Id = Guid.Parse("66666666-1111-1111-1111-111111111115"),
                Key = "DeleteIncidence-Incidence",
                Description = "Allows deleting an existing incidence"
            });
    }
}
