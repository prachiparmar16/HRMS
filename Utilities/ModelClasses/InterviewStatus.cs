using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class InterviewStatus
    {
        [Key]
        public int InterviewStatusId { get; set; }

        [Required(ErrorMessage = "Interview status is required.")]
        [MaxLength(100, ErrorMessage = "Interview status cannot exceed 100 characters.")]
        public string InterviewStatusName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}