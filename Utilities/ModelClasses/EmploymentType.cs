using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class EmploymentType
    {
        [Key]
        public int EmploymentTypeId { get; set; }

        [Required(ErrorMessage = "Employment type is required.")]
        [MaxLength(100, ErrorMessage = "Employment type cannot exceed 100 characters.")]
        public string EmploymentTypeName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}