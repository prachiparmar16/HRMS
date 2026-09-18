using System;
using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }

        [Required(ErrorMessage = "Shift name is required.")]
        [MaxLength(100, ErrorMessage = "Shift name cannot exceed 100 characters.")]
        public string ShiftName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Start time is required.")]
        public TimeSpan StartTime { get; set; }

        [Required(ErrorMessage = "End time is required.")]
        public TimeSpan EndTime { get; set; }

        public bool IsActive { get; set; } = true;
    }
}