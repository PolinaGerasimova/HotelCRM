using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCRM.Models
{
    public class BookingServiceItem
    {
        [Key]
        public int BookingServiceID { get; set; }

        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public DateTime? ServiceDate { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal TotalPrice => ItemPrice * Quantity;
        public string Notes { get; set; }
    }
}
