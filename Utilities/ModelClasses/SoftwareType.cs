using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
public class SoftwareType
    {
        [Key]
        public int SoftwareTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string SoftwareTypeName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
