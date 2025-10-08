using Microsoft.EntityFrameworkCore;
using VirtualPark.BusinessLogic.Permissions.Entity;

namespace VirtualPark.DataAccess.Seed;

public static class TicketSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission
            {
                Id = Guid.Parse("33333333-1111-1111-1111-111111111111"),
                Key = "GetTicketById-Ticket",
                Description = "Allows retrieving a ticket by ID"
            },
            new Permission
            {
                Id = Guid.Parse("33333333-1111-1111-1111-111111111112"),
                Key = "CreateTicket-Ticket",
                Description = "Allows creating new tickets"
            },
            new Permission
            {
                Id = Guid.Parse("33333333-1111-1111-1111-111111111113"),
                Key = "GetAllTickets-Ticket",
                Description = "Allows listing all tickets"
            },
            new Permission
            {
                Id = Guid.Parse("33333333-1111-1111-1111-111111111114"),
                Key = "DeleteTicket-Ticket",
                Description = "Allows deleting existing tickets"
            });
    }
}
