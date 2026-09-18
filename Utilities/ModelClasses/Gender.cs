using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }

        [Required]
        [MaxLength(50)]
        public string GenderName { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
