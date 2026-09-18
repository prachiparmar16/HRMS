using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class AllowanceType
    {

        [Key]
        public int AllowanceTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string AllowanceName { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? Description { get; set; }

        public bool IsTaxable { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

