using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class HardwareType
    {
        [Key]
        public int HardwareTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string HardwareTypeName { get; set; } = string.Empty;

        [Required]
        [MaxLength (100)]
        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }


    
    }

