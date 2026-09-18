using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        [Required]
        [MaxLength(100)]
        public string StateName { get; set; } = string.Empty;

        public int CountryId { get; set; }

        public bool IsActive { get; set; }
    }
}
