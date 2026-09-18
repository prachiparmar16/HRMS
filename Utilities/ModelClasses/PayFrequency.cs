using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class PayFrequency
    {
      
        
            [Key]
            public int PayFrequencyId { get; set; }

            [Required]
            [MaxLength(50)]
            public string FrequencyName { get; set; } = string.Empty;

            public int FrequencyDays { get; set; }

            [MaxLength(250)]
            public string? Description { get; set; }

            public bool IsActive { get; set; } = true;
        }
    }

