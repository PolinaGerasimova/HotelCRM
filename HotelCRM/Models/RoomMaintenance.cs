using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HotelCRM.Models
{
    public class RoomMaintenance
    {
        [Key]
        public int MaintenanceID { get; set; }
        public int RoomID { get; set; }
        public int? EmployeeID { get; set; }
        public string TaskDescription { get; set; }
        public DateTime ReportedDate { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public DateTime? ActualCompletionDate { get; set; }
        public string Status { get; set; }
        public decimal? Cost { get; set; }
        public string Notes { get; set; }
    }
}
