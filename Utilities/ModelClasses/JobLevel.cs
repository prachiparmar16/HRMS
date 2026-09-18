using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class JobLevel
    {
        [Key]
        public int JobLevelId { get; set; }

        [Required(ErrorMessage = "Job level is required.")]
        [MaxLength(100, ErrorMessage = "Job level cannot exceed 100 characters.")]
        public string JobLevelName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}