using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "Vehicle number is required.")]
        [StringLength(20, ErrorMessage = "Vehicle number cannot exceed 20 characters.")]
        public string VehicleNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vehicle name is required.")]
        [MaxLength(100)]
        public string VehicleName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vehicle type is required.")]
        public int VehicleTypeId { get; set; }

        public int SeatingCapacity { get; set; }

        public bool IsActive { get; set; }
    }
}
