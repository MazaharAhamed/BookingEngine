using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingEngine.Models
{
    public class GuestInfo
    {
        [Key]
        public int GuestId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        //[DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone Number")]
        //[RegularExpression(@"/0\d?\d{9,10}/g$", ErrorMessage = "Wrong mobile")]
        //[Range(1000000000, 9999999999, ErrorMessage = "Invalid Phone Number")]
        [Required]
        [RegularExpression("[0-9]{10}", ErrorMessage = "Invalid")]
        public long PhoneNumber { get; set; }

        [Required]
        public string HomeAddress { get; set; }

        [Required]
        public string AptName { get; set; }

        [Required]
        public string Country { get; set; }

        [DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }

        public PaymentInfo PaymentInfo { get; set; }

        public Booking Booking { get; set; }
    }
}