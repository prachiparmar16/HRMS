using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class Route
    {
        [Key]
        public int RouteId { get; set; }

        [Required]
        public string RouteName { get; set; } = string.Empty;

        [Required]
        public string StartPoint { get; set; } = string.Empty;

        [Required]
        public string EndPoint { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
