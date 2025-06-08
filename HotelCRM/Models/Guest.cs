using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HotelCRM.Models
{
    public class Guest
    {
        [Key]
        public int GuestID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public string PassportIssuedBy { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }

        public string FullName => $"{LastName} {FirstName} {MiddleName}".Trim();
    }
}
