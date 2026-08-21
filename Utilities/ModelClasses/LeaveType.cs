using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace HRMS.Models.ModelClasses
{
    public class LeaveType
    {
        [Key]
        public int LeaveTypeId { get; set; }

        public string LeaveTypeName { get; set; }
    }
}