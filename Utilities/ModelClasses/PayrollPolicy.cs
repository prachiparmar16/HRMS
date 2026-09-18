using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class PayrollPolicy
    {
        [Key]
        public int PayrollPolicyId { get; set; }

        [Required]
        [MaxLength(100)]
        public string PolicyName { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? Description { get; set; }

        // Foreign Key
        public int PayFrequencyId { get; set; }

        public bool IncludeTax { get; set; }

        public bool IncludePF { get; set; }

        public bool IncludeESI { get; set; }

        public bool IsActive { get; set; } = true;

        // Navigation Property
        public PayFrequency? PayFrequency { get; set; }
    }
}

