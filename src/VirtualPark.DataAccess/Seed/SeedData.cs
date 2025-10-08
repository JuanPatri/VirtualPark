using Microsoft.EntityFrameworkCore;

namespace VirtualPark.DataAccess.Seed;

public static class SeedData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        RoleSeed.Seed(modelBuilder);

        PermissionSeed.Seed(modelBuilder);

        RolePermissionSeed.Seed(modelBuilder);
    }
}
