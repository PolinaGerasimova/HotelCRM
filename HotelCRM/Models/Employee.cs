using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HotelCRM.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string WorkSchedule { get; set; }
        public string FullName => $"{LastName} {FirstName} {MiddleName}".Trim();
    }
}
