using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class SalaryGrade
    {

        [Key]
        public int SalaryGradeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string GradeName { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? Description { get; set; }

        public decimal MinimumSalary { get; set; }

        public decimal MaximumSalary { get; set; }

        public bool IsActive { get; set; } = true;
    }
}