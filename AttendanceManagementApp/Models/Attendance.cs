using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AttendanceManagementApp.Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string EmployeeName { get; set; }
        public bool IsPresent { get; set; }
        public string Notes { get; set; }
    }
}