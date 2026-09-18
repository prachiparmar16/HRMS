using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required(ErrorMessage = "Location name is required.")]
        [MaxLength(100, ErrorMessage = "Location name cannot exceed 100 characters.")]
        public string LocationName { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Branch is required.")]
        public int BranchId { get; set; }

        public bool IsActive { get; set; } = true;

        public Branch Branch { get; set; }
    }
}