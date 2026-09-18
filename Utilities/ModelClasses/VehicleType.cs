using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class VehicleType
    {
        [Key]
        public int VehicleTypeId { get; set; }

        [Required(ErrorMessage = "Vehicle type name is required.")]
        [StringLength(50, MinimumLength = 2,
           ErrorMessage = "Vehicle type must be between 2 and 50 characters.")]
        public string VehicleTypeName { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
