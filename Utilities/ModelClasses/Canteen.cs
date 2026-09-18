using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Canteen
    {
        [Key]
        public int CanteenId { get; set; }

        [Required(ErrorMessage = "Canteen name is required.")]
        [MaxLength(100, ErrorMessage = "Canteen name cannot exceed 100 characters.")]
        public string CanteenName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Location is required.")]
        [MaxLength(100, ErrorMessage = "Location cannot exceed 100 characters.")]
        public string Location { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}