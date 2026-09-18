using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Qualification
    {
        [Key]
        public int QualificationId { get; set; }

        [Required(ErrorMessage = "Qualification name is required.")]
        [MaxLength(100, ErrorMessage = "Qualification name cannot exceed 100 characters.")]
        public string QualificationName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}