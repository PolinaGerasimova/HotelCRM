using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HotelCRM.Models
{
    public class CleaningTask
    {
        [Key]
        public int CleaningTaskID { get; set; }
        public int? RoomID { get; set; }
        public string AreaName { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string TaskType { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Notes { get; set; }
    }
}
