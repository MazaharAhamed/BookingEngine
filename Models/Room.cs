using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingEngine.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        public string RoomName { get; set; }
        public double RoomCost { get; set; }

        //public GuestInfo GuestInfo { get; set; }

        //public IList<Reservation> Reservations { get; set; }

        //public Reservation Reservation { get; set; }

        public Booking Booking { get; set; }
    }
}
