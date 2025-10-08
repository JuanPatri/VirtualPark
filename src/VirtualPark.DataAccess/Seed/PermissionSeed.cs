using Microsoft.EntityFrameworkCore;
using VirtualPark.BusinessLogic.Permissions.Entity;

namespace VirtualPark.DataAccess.Seed;

public static class PermissionSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission
            {
                Id = Guid.Parse("77777777-1111-1111-1111-111111111111"),
                Key = "CreatePermission-Permission",
                Description = "Allows creating new permissions"
            },
            new Permission
            {
                Id = Guid.Parse("77777777-1111-1111-1111-111111111112"),
                Key = "GetPermissionById-Permission",
                Description = "Allows retrieving details of a specific permission"
            },
            new Permission
            {
                Id = Guid.Parse("77777777-1111-1111-1111-111111111113"),
                Key = "GetAllPermissions-Permission",
                Description = "Allows listing all permissions"
            },
            new Permission
            {
                Id = Guid.Parse("77777777-1111-1111-1111-111111111114"),
                Key = "UpdatePermission-Permission",
                Description = "Allows modifying an existing permission"
            },
            new Permission
            {
                Id = Guid.Parse("77777777-1111-1111-1111-111111111115"),
                Key = "DeletePermission-Permission",
                Description = "Allows deleting an existing permission"
            });
    }
}
