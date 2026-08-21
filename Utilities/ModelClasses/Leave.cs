using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace HRMS.Models.ModelClasses
{
    public class Leave
    {
        [Key]
        public int LeaveId { get; set; }

        public int EmployeeId { get; set; }

        public string LeaveType { get; set; }

        public DateOnly FromDate { get; set; }

        public DateOnly ToDate { get; set; }
        public DateOnly AppliedDate { get; set; }
           = DateOnly.FromDateTime(DateTime.Now);
        public int LeaveDays { get; set; }
        public string Reason { get; set; }

        public string Status { get; set; }
        
    }
}