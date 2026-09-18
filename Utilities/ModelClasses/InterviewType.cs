using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class InterviewType
    {
        [Key]
        public int InterviewTypeId { get; set; }

        [Required(ErrorMessage = "Interview type is required.")]
        [MaxLength(100, ErrorMessage = "Interview type cannot exceed 100 characters.")]
        public string InterviewTypeName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}