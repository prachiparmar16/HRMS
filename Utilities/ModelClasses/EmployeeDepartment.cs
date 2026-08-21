using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class EmployeeDepartment
    {
        [Key]
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

    }
}