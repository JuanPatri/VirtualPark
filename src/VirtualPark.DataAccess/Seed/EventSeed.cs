using Microsoft.EntityFrameworkCore;
using VirtualPark.BusinessLogic.Permissions.Entity;

namespace VirtualPark.DataAccess.Seed;

public static class EventSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission
            {
                Id = Guid.Parse("22222222-1111-1111-1111-111111111111"),
                Key = "CreateEvent-Event",
                Description = "Allows creating new events"
            },
            new Permission
            {
                Id = Guid.Parse("22222222-1111-1111-1111-111111111112"),
                Key = "GetEventById-Event",
                Description = "Allows retrieving details of a specific event"
            },
            new Permission
            {
                Id = Guid.Parse("22222222-1111-1111-1111-111111111113"),
                Key = "GetAllEvents-Event",
                Description = "Allows listing all available events"
            },
            new Permission
            {
                Id = Guid.Parse("22222222-1111-1111-1111-111111111114"),
                Key = "UpdateEvent-Event",
                Description = "Allows modifying an existing event"
            },
            new Permission
            {
                Id = Guid.Parse("22222222-1111-1111-1111-111111111115"),
                Key = "DeleteEvent-Event",
                Description = "Allows deleting an existing event"
            });
    }
}
