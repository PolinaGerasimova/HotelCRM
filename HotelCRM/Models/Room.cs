using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HotelCRM.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int MaxOccupancy { get; set; }
        public decimal BasePricePerNight { get; set; }
        public string Status { get; set; } // Available, Occupied, Cleaning, Maintenance, OutOfOrder
    }
}
