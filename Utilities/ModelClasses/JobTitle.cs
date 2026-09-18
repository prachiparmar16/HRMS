using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class JobTitle
    {
        [Key]
        public int JobTitleId { get; set; }

        [Required(ErrorMessage = "Job title is required.")]
        [MaxLength(100, ErrorMessage = "Job title cannot exceed 100 characters.")]
        public string JobTitleName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}