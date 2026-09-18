using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class BloodGroup
    {
        [Key]
        public int BloodGroupId { get; set; }

        [Required]
        [MaxLength(50)]
        public string BloodGroupName { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
