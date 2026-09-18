using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }

        [Required(ErrorMessage = "Driver name is required.")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "Driver name must be between 2 and 100 characters.")]
        public string DriverName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Contact Number is required.")]
        [Phone(ErrorMessage = "Enter a valid contact number.")]
        public string ContactNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Driving license number is required.")]
        [StringLength(30, ErrorMessage = "License number cannot exceed 30 characters.")]
        public string LicenseNumber { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
