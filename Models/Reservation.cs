using ExpressiveAnnotations.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookingEngine.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required (ErrorMessage = "Please select checkin date")]
        [DataType(DataType.Date)]
        public DateTime CheckIn { get; set; }

        [Required (ErrorMessage = "Please select checkout date")]
        [DataType(DataType.Date)]
        [AssertThat("CheckOut > CheckIn",ErrorMessage = "CheckOut date must be greater than CheckIn date")]
        public DateTime CheckOut { get; set; }

        [Required (ErrorMessage = "Please enter more than 0")]
        [Range (1,4)]
        public int Adults { get; set; }

        public Booking Booking { get; set; }
    }
}
