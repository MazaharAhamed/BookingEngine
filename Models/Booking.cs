using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingEngine.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        //public IList<Room> Room { get; set; }

        public ICollection<Room> Room { get; set; }

        public Reservation Reservation { get; set; }

        public GuestInfo GuestInfo { get; set; }

        //[ForeignKey("Room")]
        public int RoomId { get; set; }

        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }

        [ForeignKey("GuestInfo")]
        public int GuestId { get; set; }
    }
}