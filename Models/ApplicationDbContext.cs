using Microsoft.EntityFrameworkCore;

namespace BookingEngine.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts):base(opts)
        {

        }

        //#region Another way of using seeddata
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Room>()
        //        .ToTable("Room");
        //    modelBuilder.Entity<Room>()
        //        .Property(r => r.RoomId);
        //    modelBuilder.Entity<Room>()
        //        .Property(r => r.RoomName);
        //    modelBuilder.Entity<Room>()
        //        .Property(r => r.RoomCost);
        //    modelBuilder.Entity<Room>()
        //        .HasData(new Room
        //        {
        //            RoomId = 1,
        //            RoomName = "Room101",
        //            RoomCost = 75.00
        //        },
        //        new Room
        //        {
        //            RoomId = 2,
        //            RoomName = "Room 102",
        //            RoomCost = 275.00
        //        },
        //        new Room
        //        {
        //            RoomId = 3,
        //            RoomName = "Room 103",
        //            RoomCost = 55.00
        //        },
        //        new Room
        //        {
        //            RoomId = 4,
        //            RoomName = "Room 104",
        //            RoomCost = 85.00
        //        },
        //        new Room
        //        {
        //            RoomId = 5,
        //            RoomName = "Room 105",
        //            RoomCost = 125.00
        //        },
        //        new Room
        //        {
        //            RoomId = 6,
        //            RoomName = "Room 106",
        //            RoomCost = 95.00
        //        }
        //        );
        //}

        //#endregion
        public DbSet<Room> Rooms { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<GuestInfo> GuestInfo { get; set; }

        public DbSet<PaymentInfo> PaymentInfo { get; set; }
    }
}
