using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class DeductionType
    {
        [Key]
        public int DeductionTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DeductionName { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? Description { get; set; }

        public bool IsMandatory { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

