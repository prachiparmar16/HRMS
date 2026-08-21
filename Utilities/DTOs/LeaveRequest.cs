using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS.Models.DTOs
{
    public class LeaveRequest
    {
        public int EmployeeId { get; set; }

        public string LeaveType { get; set; }

        public DateOnly FromDate { get; set; }

        public DateOnly ToDate { get; set; }

        public string Reason { get; set; }
    }
}