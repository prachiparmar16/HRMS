using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CityName { get; set; } = string.Empty;

        public int StateId { get; set; }

        public bool IsActive { get; set; }
    }
}
