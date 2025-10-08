using Microsoft.EntityFrameworkCore;
using VirtualPark.BusinessLogic.Permissions.Entity;

namespace VirtualPark.DataAccess.Seed;

public static class UserSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission
            {
                Id = Guid.Parse("10101010-1111-1111-1111-111111111111"),
                Key = "GetUserById-User",
                Description = "Allows retrieving details of a specific user"
            },
            new Permission
            {
                Id = Guid.Parse("10101010-1111-1111-1111-111111111112"),
                Key = "GetAllUsers-User",
                Description = "Allows listing all users"
            },
            new Permission
            {
                Id = Guid.Parse("10101010-1111-1111-1111-111111111113"),
                Key = "UpdateUser-User",
                Description = "Allows updating user data"
            },
            new Permission
            {
                Id = Guid.Parse("10101010-1111-1111-1111-111111111114"),
                Key = "DeleteUser-User",
                Description = "Allows deleting a user"
            },
            new Permission
            {
                Id = Guid.Parse("10101010-1111-1111-1111-111111111115"),
                Key = "CreateUser-User",
                Description = "Allows creating a user"
            });
    }
}
