using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingEngine.Models
{
    public class PaymentInfo
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("GuestInfo")]
        public int GuestId { get; set; }

        [DataType(DataType.CreditCard)]
        [Required]
        public long CreditCard { get; set; }

        [Display(Name = "Exp. Date (MM/YY)")]
        [DisplayFormat(DataFormatString = "{0:MM-yy}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{MM/YY}")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ExpDate { get; set; }

        [Required]
        public string FullNameOnCard { get; set; }

        [Required]
        [Range(100, 999)]
        public int Cvv { get; set; }

        public GuestInfo GuestInfo { get; set; }
    }
}