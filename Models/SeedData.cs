using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookingEngine.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Rooms.Any())
            {
                context.Rooms.AddRange(new Room { RoomName = "Room 101", RoomCost = 75.00 },
                new Room
                {
                    RoomName = "Room 102",
                    RoomCost = 275.00
                },
                new Room
                {
                    RoomName = "Room 103",
                    RoomCost = 55.00
                },
                new Room
                {
                    RoomName = "Room 104",
                    RoomCost = 85.00
                },
                new Room
                {
                    RoomName = "Room 105",
                    RoomCost = 125.00
                },
                new Room
                {
                    RoomName = "Room 106",
                    RoomCost = 95.00
                }
                );
                context.SaveChanges();
            }
        }
    }
}