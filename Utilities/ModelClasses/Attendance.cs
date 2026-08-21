using System;
using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        public int EmployeeId { get; set; }

        public DateOnly AttendanceDate { get; set; }

        public DateTime? CheckInTime { get; set; }

        public DateTime? CheckOutTime { get; set; }

        public string Status { get; set; }

        public string Remarks { get; set; }
    }
}