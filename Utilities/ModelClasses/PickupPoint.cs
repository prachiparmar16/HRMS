using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class PickupPoint
    {
        [Key]
        public int PickupPointId { get; set; }

        [Required(ErrorMessage = "Pickup point name is required.")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "Pickup point name must be between 2 and 100 characters.")]
        public string PickupPointName { get; set; } = string.Empty;

        public int RouteId { get; set; }

        public bool IsActive { get; set; }
    }
}
