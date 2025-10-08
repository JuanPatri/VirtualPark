using Microsoft.EntityFrameworkCore;
using VirtualPark.BusinessLogic.Permissions.Entity;

namespace VirtualPark.DataAccess.Seed;

public static class TypeIncidenceSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission
            {
                Id = Guid.Parse("44444444-1111-1111-1111-111111111111"),
                Key = "CreateTypeIncidence-TypeIncidence",
                Description = "Allows creating new incidence types"
            },
            new Permission
            {
                Id = Guid.Parse("44444444-1111-1111-1111-111111111112"),
                Key = "GetTypeIncidenceById-TypeIncidence",
                Description = "Allows retrieving a specific incidence type"
            },
            new Permission
            {
                Id = Guid.Parse("44444444-1111-1111-1111-111111111113"),
                Key = "GetAllTypeIncidences-TypeIncidence",
                Description = "Allows listing all incidence types"
            },
            new Permission
            {
                Id = Guid.Parse("44444444-1111-1111-1111-111111111114"),
                Key = "DeleteTypeIncidence-TypeIncidence",
                Description = "Allows deleting an incidence type"
            },
            new Permission
            {
                Id = Guid.Parse("44444444-1111-1111-1111-111111111115"),
                Key = "UpdateTypeIncidence-TypeIncidence",
                Description = "Allows updating an incidence type"
            });
    }
}
