using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class SalaryComponent
    {


        [Key]
        public int SalaryComponentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string ComponentName { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string ComponentType { get; set; } = string.Empty;
        // Earning / Deduction

        public bool IsTaxable { get; set; }

        public bool IsActive { get; set; } = true;
    }
}