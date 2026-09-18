using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class JobType
    {
        [Key]
        public int JobTypeId { get; set; }

        [Required(ErrorMessage = "Job type is required.")]
        [MaxLength(100, ErrorMessage = "Job type cannot exceed 100 characters.")]
        public string JobTypeName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}