using Microsoft.EntityFrameworkCore;
using VirtualPark.BusinessLogic.Permissions.Entity;
using VirtualPark.BusinessLogic.Roles.Entity;

namespace VirtualPark.DataAccess.Seed;

public static class RoleSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission
            {
                Id = Guid.Parse("99999999-1111-1111-1111-111111111111"),
                Key = "CreateRole-Role",
                Description = "Allows creating new roles"
            },
            new Permission
            {
                Id = Guid.Parse("99999999-1111-1111-1111-111111111112"),
                Key = "GetRoleById-Role",
                Description = "Allows retrieving details of a specific role"
            },
            new Permission
            {
                Id = Guid.Parse("99999999-1111-1111-1111-111111111113"),
                Key = "GetAllRoles-Role",
                Description = "Allows listing all existing roles"
            },
            new Permission
            {
                Id = Guid.Parse("99999999-1111-1111-1111-111111111114"),
                Key = "UpdateRole-Role",
                Description = "Allows modifying an existing role"
            },
            new Permission
            {
                Id = Guid.Parse("99999999-1111-1111-1111-111111111115"),
                Key = "DeleteRole-Role",
                Description = "Allows deleting an existing role"
            });
        modelBuilder.Entity<Role>().HasData(
            new Role { Id = Guid.Parse("AAAA1111-1111-1111-1111-111111111111"), Name = "Administrator", Description = "Full system access" },
            new Role { Id = Guid.Parse("BBBB1111-1111-1111-1111-111111111111"), Name = "Operator", Description = "Attraction operator" },
            new Role { Id = Guid.Parse("CCCC1111-1111-1111-1111-111111111111"), Name = "Visitor", Description = "Regular park visitor" });
    }
}
