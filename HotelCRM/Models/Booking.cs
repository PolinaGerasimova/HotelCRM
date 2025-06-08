using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HotelCRM.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public int GuestID { get; set; }
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfGuests { get; set; }
        public int? TariffID { get; set; }
        public string Status { get; set; } // Confirmed, CheckedIn, CheckedOut, Cancelled
        public DateTime? ActualCheckInTime { get; set; }
        public DateTime? ActualCheckOutTime { get; set; }
        public decimal TotalPriceAccommodation { get; set; }
        public decimal TotalPriceServices { get; set; }
        public decimal FinalBillAmount { get; set; }
        public string Notes { get; set; }

        public List<BookingServiceItem> AppliedServices { get; set; } = new List<BookingServiceItem>();
    }


}
